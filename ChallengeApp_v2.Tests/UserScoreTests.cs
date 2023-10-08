using Dzieñ_6___lekcje;

namespace ChallengeApp_v2.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ThenReturnCorrectSumAsResult()
        {
            // arrange
            var user = new User("Adam", "0123456789");
            user.AddScore(5);
            user.AddScore(6);

            // act
            var result = user.Result;

            // assert
            Assert.That(result, Is.EqualTo(11));
        }


        [Test]
        public void WhenUserCollectnegativePoints_ThenReturnCorrectSumAsResult()
        {
            // arrange
            var user = new User("Adam", "0123456789");
            user.AddScore(5);
            user.AddScore(-5);
            user.AddScore(6);
            user.AddScore(-5);

            // act
            var result = user.Result;

            // assert
            Assert.That(result, Is.EqualTo(1));
        }

    }
}