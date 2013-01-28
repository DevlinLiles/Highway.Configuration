using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Highway.Configuration.Core.Entities;
using Highway.Configuration.Core.Interfaces;
using Highway.Configuration.Web.Controllers;
using Highway.Configuration.Web.Models;
using NUnit.Framework;
using Rhino.Mocks;

namespace Highway.Configuration.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void ShouldReturnListOfApplicationsForTheUserOnIndex()
        {
            //Arrange
            var application = new Application()
                {
                    Id = 1,
                    Name = "Test",
                    Settings = new List<ApplicationSetting>()
                        {
                            new ApplicationSetting(),
                            new ApplicationSetting()
                        }
                };

            var mockApplicationService = MockRepository.GenerateMock<IApplicationService>();
            mockApplicationService.Expect(x => x.GetApplicationsByUser(Arg<string>.Is.Equal("Test")))
                                  .Return(new List<Application>()
                                      {
                                          application
                                      });

            var mockPrincipalService = MockRepository.GenerateMock<IPrincipalService>();
            mockPrincipalService.Expect(x => x.GetCurrentUserName()).Return("Test");
            var target = new HomeController(mockApplicationService, mockPrincipalService);

            //Act
            var results = target.Index();

            //Assert
            Assert.IsAssignableFrom<ViewResult>(results);

            ViewResult typedResult = (ViewResult) results;
            Assert.IsAssignableFrom<HomeIndexViewModel>(typedResult.Model);
            var typedModel = (HomeIndexViewModel) typedResult.Model;
            Assert.AreEqual(1, typedModel.Applications.Count());
            Assert.AreEqual("Test",typedModel.Applications.First().Name);
            Assert.AreEqual(1, typedModel.Applications.First().Id);

        }
    }
}