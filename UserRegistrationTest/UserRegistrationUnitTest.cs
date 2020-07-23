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
        public void givenFirstName_WhenImProper_ShouldReturnFalse()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validFirstName("V");
            Assert.IsFalse(isValid);

        }

        [Test]
        public void givenLastName_WhenProper_ShouldReturnTrue()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validLastName("Tathe");
            Assert.IsTrue(isValid);
        }

        [Test]
        public void givenLastName_WhenImProper_ShouldReturnFalse()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validLastName("V");
            Assert.IsFalse(isValid);

        }

        [Test]
        public void givenEmailID_WhenProper_ShouldReturnTrue()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validEmail("vaidehitathe30@gmail.com");
            Assert.IsTrue(isValid);
        }

        [Test]
        public void givenEmailID_WhenImProper_ShouldReturnFalse()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validEmail("xyz.abc@com");
            Assert.IsFalse(isValid);

        }

        [Test]
        public void givenPhoneNumber_WhenProper_ShouldReturnTrue()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validPhoneNumber("91 9881711714");
            Assert.IsTrue(isValid);
        }

        [Test]
        public void givenPhoneNumber_WhenImProper_ShouldReturnFalse()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validPhoneNumber("91 8987");
            Assert.IsFalse(isValid);

        }

        [Test]
        public void givenPassword_WhenProper_ShouldReturnTrue()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validPassword("ghduethb");
            Assert.IsTrue(isValid);
        }

        [Test]
        public void givenPassword_WhenImProper_ShouldReturnTrue()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validPassword("ghdu");
            Assert.IsFalse(isValid);
        }

        [Test]
        public void givenPasswordRule2_WhenProper_ShouldReturnTrue()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validPasswordRule2("Ghduethb");
            Assert.IsTrue(isValid);
        }

        [Test]
        public void givenPasswordRule2_WhenImProper_ShouldReturnTrue()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validPasswordRule2("ghduhutg");
            Assert.IsFalse(isValid);
        }

        [Test]
        public void givenPasswordRule3_WhenProper_ShouldReturnTrue()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validPasswordRule3("vaidehi123");
            Assert.IsTrue(isValid);
        }

        [Test]
        public void givenPasswordRule3_WhenImProper_ShouldReturnTrue()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validPasswordRule3("vaidehitathe");
            Assert.IsFalse(isValid);
        }

        [Test]
        public void givenPasswordRule4_WhenProper_ShouldReturnTrue()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validPasswordRule4("vaidehi@123");
            Assert.IsTrue(isValid);
        }

        [Test]
        public void givenPasswordRule4_WhenImProper_ShouldReturnTrue()
        {
            UserRegistration.UserRegistrationUtility user = new UserRegistration.UserRegistrationUtility();
            bool isValid = user.validPasswordRule4("vaidehitathe");
            Assert.IsFalse(isValid);
        }
    }
}