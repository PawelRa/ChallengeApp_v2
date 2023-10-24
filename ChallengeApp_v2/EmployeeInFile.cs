using System.Diagnostics;

namespace ChallengeApp_v2
{
    public class EmployeeInFile : EmployeeBase
    {

        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Invalid grade data");
            }
        }

        public override void AddGrade(char grade)
        {
            switch (char.ToUpper(grade))
            {
                case 'A':
                    this.AddGrade(100);
                    break;
                case 'B':
                    this.AddGrade(80);
                    break;
                case 'C':
                    this.AddGrade(60);
                    break;
                case 'D':
                    this.AddGrade(40);
                    break;
                case 'E':
                    this.AddGrade(20);
                    break;
                default:
                    this.AddGrade(0);
                    throw new Exception("Wrong Letter");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            var lines = 0;

            result.Average = 0;
            result.Max = float.MinValue;
            result.Min = float.MaxValue;


            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    Console.WriteLine(line);
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        result.Max = Math.Max(result.Max, number);
                        result.Min = Math.Min(result.Min, number);
                        result.Average += number;
                        lines++;
                    }
                    result.Average /= lines;

                    switch (result.Average)
                    {
                        case var average when average >= 100:
                            result.AverageLetter = 'A';
                            break;
                        case var average when average >= 80:
                            result.AverageLetter = 'B';
                            break;
                        case var average when average >= 60:
                            result.AverageLetter = 'C';
                            break;
                        case var average when average >= 40:
                            result.AverageLetter = 'D';
                            break;
                        case var average when average >= 20:
                            result.AverageLetter = 'E';
                            break;
                        default:
                            throw new Exception("Bad letter");
                    }

                }
             //   File.Delete(fileName);
            }
            return result;
        }
    }
}
