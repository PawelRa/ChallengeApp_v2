namespace ChallengeApp_v2
{
    public class Supervisor : IEmployee
    {

        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade data");
            }
        }

        public void AddGrade(string grade)
        {
            int numberOfPoints = 0;

            foreach (char g in grade)
            {
                switch (g)
                {
                    case '-':
                        numberOfPoints -= 5;
                        break;
                    case '+':
                        numberOfPoints += 5;
                        break;
                    case '6':
                        numberOfPoints += 100;
                        break;
                    case '5':
                        numberOfPoints += 80;
                        break;
                    case '4':
                        numberOfPoints += 60;
                        break;
                    case '3':
                        numberOfPoints += 40;
                        break;
                    case '2':
                        numberOfPoints += 20;
                        break;
                    default:
                        numberOfPoints += 0;
                        break;
                }
            }

            this.AddGrade(numberOfPoints);
        }

        public void AddGrade(double grade)
        {
            float value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(int grade)
        {
            float value = grade;
            this.AddGrade(value);
        }

            public void AddGrade(long grade)
        {
            if (float.TryParse(grade.ToString(), out float value))
            {
                this.AddGrade(value);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public float Result
        {
            get
            {
                return this.grades.Sum();
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 100:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 80:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'D';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'E';
                    break;
                default:
                    throw new Exception("Bad letter");
            }

            return statistics;
        }
    }
}
