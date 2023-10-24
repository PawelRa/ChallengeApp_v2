namespace ChallengeApp_v2
{
    public abstract class EmployeeBase : IEmployee
    {

        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public abstract void AddGrade(float grade);

        public virtual void AddGrade(double grade)
        {
            float value = (float)grade;
            this.AddGrade(value);
        }


        public virtual void AddGrade(int grade)
        {
            float value = grade;
            this.AddGrade(value);
        }

        public virtual void AddGrade(string grade)
        {
            if (grade.Length == 1)
            {
                this.AddGrade(grade[0]);
            }
            else if (float.TryParse(grade, out float value))
            {
                this.AddGrade(value);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public virtual void AddGrade(char grade)
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
                    throw new Exception("Wrong Letter");
            }
        }

        public abstract Statistics GetStatistics();
    }
}
