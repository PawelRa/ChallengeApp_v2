namespace ChallengeApp_v2.Tests
{
    public class EmployeeStatisticsTests
    {
        [Test]
        public void WhenEmployeeInMemoryGetGrades_ThenReturnCorrectSum()
        {
            //arrange
            var emp = new EmployeeInMemory("Amadeusz", "Kubiak");
            emp.AddGrade(20);
            emp.AddGrade(20);
            emp.AddGrade(40);

            //act
            var result = emp.Result;

            //assert
            Assert.That(80, Is.EqualTo(result));
        }

        [Test]
        public void MaxValueEmployeeInMemoryTest()
        {
            //arrange
            var emp = new EmployeeInMemory("Amadeusz", "Kubiak");
            emp.AddGrade(20);
            emp.AddGrade(20f);
            emp.AddGrade("40");
            var statistics = emp.GetStatistics();

            //act
            var max = statistics.Max;

            //assert
            Assert.That(40, Is.EqualTo(max));
        }

        [Test]
        public void MinValueEmployeeInMemoryTest()
        {
            //arrange
            var emp = new EmployeeInMemory("Amadeusz", "Kubiak");
            emp.AddGrade(20);
            emp.AddGrade(20);
            emp.AddGrade(40);
            var statistics = emp.GetStatistics();

            //act
            var min = statistics.Min;

            //assert
            Assert.That(20, Is.EqualTo(min));
        }

        [Test]
        public void AverageValueEmployeeInMemoryTest()
        {
            //arrange
            var emp = new EmployeeInMemory("Amadeusz", "Kubiak");
            emp.AddGrade(30);
            emp.AddGrade(20);
            emp.AddGrade(40);
            var statistics = emp.GetStatistics();

            //act
            var average = statistics.Average;

            //assert
            Assert.That(30, Is.EqualTo(average));
        }

        [Test]
        public void MaxValueEmployeeInFileTest()
        {
            //arrange
            var emp = new EmployeeInFile("Amadeusz", "Kubiak");
            emp.AddGrade(20);
            emp.AddGrade(20f);
            emp.AddGrade("40");
            var statistics = emp.GetStatistics();

            //act
            var max = statistics.Max;
            emp.FileDelete();

            //assert
            Assert.That(40, Is.EqualTo(max));
        }

        [Test]
        public void MinValueEmployeeInFileTest()
        {
            //arrange
            var emp = new EmployeeInFile("Amadeusz", "Kubiak");
            emp.AddGrade(20);
            emp.AddGrade(20);
            emp.AddGrade(40);
            var statistics = emp.GetStatistics();

            //act
            var min = statistics.Min;
            emp.FileDelete();

            //assert
            Assert.That(20, Is.EqualTo(min));
        }

        [Test]
        public void AverageValueEmployeeInFileTest()
        {
            //arrange
            var emp = new EmployeeInFile("Amadeusz", "Kubiak");
            emp.AddGrade(30);
            emp.AddGrade(20);
            emp.AddGrade(40);
            var statistics = emp.GetStatistics();

            //act
            var average = statistics.Average;
            emp.FileDelete();

            //assert
            Assert.That(30, Is.EqualTo(average));
        }
    }
}
