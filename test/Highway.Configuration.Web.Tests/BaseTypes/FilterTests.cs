using System;
using System.Web.Mvc;
using System.Web.SessionState;
using Castle.Core.Logging;
using Highway.Configuration.Core.Interfaces;
using Highway.Configuration.Shared.Tests.ControllerFakes;
using Highway.Configuration.Web.BaseTypes;
using Highway.Configuration.Web.Controllers;
using Highway.Configuration.Web.Filters;
using NUnit.Framework;
using Rhino.Mocks;

namespace Highway.Configuration.Web.Tests.BaseTypes
{
    [TestFixture]
    public class FilterTests
    {
        [Test]
        public void ShouldGetCreatedWithNullLogger()
        {
            //Arrange


            //Act
            var target = new ExceptionLoggingFilter();

            //Assert
            Assert.IsNotNull(target);
            Assert.IsNotNull(target.Logger);
            Assert.IsInstanceOf<NullLogger>(target.Logger);

        }

        [Test]
        public void ShouldLogExceptionsWithURL()
        {
            //Arrange
            var mockApplicationService = MockRepository.GenerateStub<IApplicationService>();
            var mockPrincipalService = MockRepository.GenerateStub<IPrincipalService>();
            var expectedException = new ApplicationException("Testing");
            var context =
                new ExceptionContext(
                    new FakeControllerContext(new HomeController(mockApplicationService, mockPrincipalService), "Test",
                                              new[]{"Retest"}, null, null, null, new SessionStateItemCollection()),
                    expectedException);

            var target = new ExceptionLoggingFilter();
            var logger = MockRepository.GenerateMock<ILogger>();
            target.Logger = logger;

            //Act
            target.OnException(context);

            //Assert
            logger.AssertWasCalled(x => x.Error(Arg<string>.Is.Equal("http://testing.com/URL"), Arg<Exception>.Is.Equal(expectedException)));
        }
    }
}