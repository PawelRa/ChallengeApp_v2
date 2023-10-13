using Dzien_6___zadanie_domowe;

namespace ChallengeApp_v2.Tests
{
    public class EmployeeStatisticsTests
    {
        [Test]
        public void WhenEmployeeGetGrades_ThenReturnCorrectSum()
        {
            //arrange
            var emp = new Employee("Amadeusz", "Kubiak");
            emp.AddGrade(2);
            emp.AddGrade(2);
            emp.AddGrade(4);
            emp.AddGrade(-4);

            //act
            var result = emp.Result;

            //assert
            Assert.That(8, Is.EqualTo(result));
        }

        [Test]
        public void MaxValueTest()
        {
            //arrange
            var emp = new Employee("Amadeusz", "Kubiak");
            emp.AddGrade('2');
            emp.AddGrade(2);
            emp.AddGrade("4");
            emp.AddGrade(2000);
            var statistics = emp.GetStatistics();

            //act
            var max = statistics.Max;

            //assert
            Assert.That(4, Is.EqualTo(max));
        }

        [Test]
        public void MinValueTest()
        {
            //arrange
            var emp = new Employee("Amadeusz", "Kubiak");
            emp.AddGrade(2);
            emp.AddGrade(2);
            emp.AddGrade(4);
            var statistics = emp.GetStatistics();

            //act
            var min = statistics.Min;

            //assert
            Assert.That(2, Is.EqualTo(min));
        }

        [Test]
        public void AverageValueTest()
        {
            //arrange
            var emp = new Employee("Amadeusz", "Kubiak");
            emp.AddGrade(3);
            emp.AddGrade(2);
            emp.AddGrade(4);
            var statistics = emp.GetStatistics();

            //act
            var average = statistics.Average;

            //assert
            Assert.That(3, Is.EqualTo(average));
        }
    }
}
