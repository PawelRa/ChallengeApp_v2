using Dzień_6___lekcje;

namespace ChallengeApp_v2.Tests
{
    public class TypeTest
    {
        [Test]
        public void TestValueTypes()
        {
            // arrange
            int number1 = 1;
            int number2 = 1;

            // act

            // assert
            Assert.AreEqual(number1, number2);

        }


        [Test]
        public void TEST()
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
