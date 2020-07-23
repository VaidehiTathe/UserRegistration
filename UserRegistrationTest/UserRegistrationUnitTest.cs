using NUnit.Framework;

namespace UserRegistrationTest
{
    public class UserRegistrationUnitTest
    {
        [Test]
        public void givenFirstName_WhenProper_ShouldReturnTrue()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validFirstName("Vaidehi");
            Assert.IsTrue(isValid);
        }

        [Test]
        public void givenLastName_WhenProper_ShouldReturnTrue()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validFirstName("Tathe");
            Assert.IsTrue(isValid);
        }
    }
}