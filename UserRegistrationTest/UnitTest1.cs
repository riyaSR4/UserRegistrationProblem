using UserRegistration;

namespace UserRegistrationTest
{
    public class Tests
    {

        [Test]
        public void TestFirstName()
        {
            string input = "Riya";
            Validate firstName = new Validate();
            bool result = firstName.ValidateFirstName(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestLastName()
        {
            string input = "Reji";
            Validate lastName = new Validate();
            bool result = lastName.ValidateLastName(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestEmail()
        {
            string input = "riyareji@gmail.com";
            Validate email = new Validate();
            bool result = email.ValidateEmail(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestPhoneNumber()
        {
            string input = "91 9012345678";
            Validate phonenumber = new Validate();
            bool result = phonenumber.ValidatePhoneNumber(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestCheckCharacter()
        {
            string input = "riya@1234";
            Validate character = new Validate();
            bool result = character.ValidateCheckCharacter(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestUpperCase()
        {
            string input = "Riya1234";
            Validate uppercase = new Validate();
            bool result = uppercase.ValidateUpperCase(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestNumeric()
        {
            string input = "Riya1234";
            Validate numeric = new Validate();
            bool result = numeric.ValidateNumeric(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestSpecialCharacter()
        {
            string input = "Riya@1234";
            Validate special = new Validate();
            bool result = special.ValidateSpecialCharacter(input);
            Assert.IsTrue(result);
        }
    }
}