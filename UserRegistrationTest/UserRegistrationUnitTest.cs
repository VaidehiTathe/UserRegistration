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
            bool isValid = user.validLastName("Tathe");
            Assert.IsTrue(isValid);
        }

        [Test]
        public void givenEmailID_WhenProper_ShouldReturnTrue()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validEmail("vaidehitathe30@gmail.com");
            Assert.IsTrue(isValid);
        }

        [Test]
        public void givenPhoneNumber_WhenProper_ShouldReturnTrue()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validPhoneNumber("91 9881711714");
            Assert.IsTrue(isValid);
        }

        [Test]
        public void givenPassword_WhenProper_ShouldReturnTrue()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validPassword("ghduethb");
            Assert.IsTrue(isValid);
        }
    }
}