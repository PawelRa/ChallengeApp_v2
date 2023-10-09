using Dzień_6___lekcje;

namespace ChallengeApp_v2.Tests
{
    public class TypeTest
    {
        [Test]
        public void TestValueTypesInt()
        {
            // arrange
            int number1 = 1;
            int number2 = 1;

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TestValueTypesFloat()
        {
            // arrange
            float number1 = 15461415565;
            float number2 = 15461415565;

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TestValueTypesDouble()
        {
            // arrange
            double number1 = 85421.5452354;
            double number2 = 85421.5452354;

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TestValueTypesString()
        {
            // arrange
            string name1 = "Adam";
            string name2 = "Adam";

            // act

            // assert
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void ReferenceTypesTest()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            // act

            // assert
            Assert.AreNotEqual(user1, user2);
        }

        private User GetUser(string name)
        {
            return new User(name, "0123456789");
        }
    }
}
