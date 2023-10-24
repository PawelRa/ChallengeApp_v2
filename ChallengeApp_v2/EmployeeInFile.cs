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

        public void FileDelete()
        {
            File.Delete(fileName);
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
                        line = reader.ReadLine();
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
            }
            return result;
        }
    }
}
