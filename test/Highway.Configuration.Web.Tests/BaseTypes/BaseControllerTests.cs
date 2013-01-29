using Castle.Core.Logging;
using Highway.Configuration.Web.BaseTypes;
using NUnit.Framework;

namespace Highway.Configuration.Web.Tests.BaseTypes
{
    [TestFixture]
    public class BaseControllerTests
    {
        [Test]
        public void ShouldCreateWithANullLogger()
        {
            //Act
            var target = new BaseController();

            //Assert
            Assert.IsNotNull(target);
            Assert.IsNotNull(target.Logger);
            Assert.IsInstanceOf<NullLogger>(target.Logger);
        }
    }
}