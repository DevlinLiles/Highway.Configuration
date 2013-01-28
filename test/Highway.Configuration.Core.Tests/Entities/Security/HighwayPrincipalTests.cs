using Highway.Configuration.Core.Entities.Security;
using NUnit.Framework;

namespace Highway.Configuration.Core.Tests.Entities.Security
{
    [TestFixture]
    public class HighwayPrincipalTests
    {
        [Test]
        public void ShouldCheckIsInRolesCorrectlyForPositiveRole()
        {
            //Arrange
            var target = new HighwayPrincipal(new HighwayIdentity("Test"),new[]{"Admin","SiteAdmin","ViewApplication"} );



            //Act
            var result = target.IsInRole("Admin");

            //Assert
            Assert.AreEqual(true,result);
        }

        [Test]
        public void ShouldCheckIsInRoleProperlyForNegativeRole()
        {
            //Arrange
            var target = new HighwayPrincipal(new HighwayIdentity("Test"), new[] { "Admin", "SiteAdmin", "ViewApplication" });



            //Act
            var result = target.IsInRole("GlobalAdmin");

            //Assert
            Assert.AreEqual(false, result);
        }


        [Test]
        public void ShouldCheckIsInRoleProperlyForNegativeRoles()
        {
            //Arrange
            var target = new HighwayPrincipal(new HighwayIdentity("Test"), new[] { "Admin", "SiteAdmin", "ViewApplication" });



            //Act
            var requiredRoles = new[] {"Admin", "GlobalAdmin"};
            var result = target.IsInRole("Admin, GlobalAdmin",true);

            //Assert
            Assert.AreEqual(false, result);
        }

        [Test]
        public void ShouldCheckIsInRoleProperlyForPositiveRoles()
        {
            //Arrange
            var target = new HighwayPrincipal(new HighwayIdentity("Test"), new[] { "Admin", "SiteAdmin", "ViewApplication" });



            //Act
            var requiredRoles = new[] { "Admin", "GlobalAdmin" };
            var result = target.IsInRole("Admin, SiteAdmin", true);

            //Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void ShouldCheckIsInRoleProperlyForPartialPositiveRoles()
        {
            //Arrange
            var target = new HighwayPrincipal(new HighwayIdentity("Test"), new[] { "Admin", "SiteAdmin", "ViewApplication" });



            //Act
            var requiredRoles = new[] { "Admin", "GlobalAdmin" };
            var result = target.IsInRole("Admin, ViewApplication, GlobalAdmin", false);

            //Assert
            Assert.AreEqual(true, result);
        }
    }
}