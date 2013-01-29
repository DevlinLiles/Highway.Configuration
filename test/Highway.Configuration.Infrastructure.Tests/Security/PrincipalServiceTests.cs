using System.Threading;
using Highway.Configuration.Infrastructure.Security;
using Highway.Configuration.Shared.Tests.ControllerFakes;
using NUnit.Framework;

namespace Highway.Configuration.Infrastructure.Tests.Security
{
    [TestFixture]
    public class PrincipalServiceTests
    {
        [Test]
        public void ShouldFindRolesForUser()
        {
            //Arrange
            Thread.CurrentPrincipal = new FakePrincipal(new FakeIdentity("Test"),new[]{"Test","Admin"});
            var target = new PrincipalService();
            //Act
            var results = target.GetCurrentPrincipal();

            //Assert
            Assert.IsNotNull(results);
            Assert.AreEqual("Test",results.Identity.Name);
            Assert.IsTrue(results.IsInRole("Admin"));
            Assert.IsTrue(results.IsInRole("Test"));
        }

        [Test]
        public void ShouldFindCurrentUserName()
        {
            //Arrange
            Thread.CurrentPrincipal = new FakePrincipal(new FakeIdentity("Test"), new[] { "Test", "Admin" });
            var target = new PrincipalService();

            //Act
            var result = target.GetCurrentUserName();

            //Assert
            Assert.IsNotNullOrEmpty(result);
            Assert.AreEqual("Test", result);
        }

        [Test]
        public void ShouldFindRoleThatIsPresent()
        {
            //Arrange
            Thread.CurrentPrincipal = new FakePrincipal(new FakeIdentity("Test"), new[] { "Test", "Admin" });
            var target = new PrincipalService();

            //Act
            var result = target.SecurityCheck("Test");

            //Assert
            Assert.IsTrue(result);
        }


        [Test]
        public void ShouldNotFindRoleThatIsNotPresent()
        {
            //Arrange
            Thread.CurrentPrincipal = new FakePrincipal(new FakeIdentity("Test"), new[] { "Test", "Admin" });
            var target = new PrincipalService();

            //Act
            var result = target.SecurityCheck("Test2");

            //Assert
            Assert.IsFalse(result);
        }
    }
}