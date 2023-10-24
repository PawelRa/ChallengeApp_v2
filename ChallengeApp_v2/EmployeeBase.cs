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

        public virtual void AddGrade(string grade) {
            if ((grade.Length == 1) && (char.ToUpper(grade[0]) == 'A' || char.ToUpper(grade[0]) == 'B'
        || char.ToUpper(grade[0]) == 'C' || char.ToUpper(grade[0]) == 'D' || char.ToUpper(grade[0]) == 'E'))
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

        public abstract void AddGrade(char grade);

        public abstract Statistics GetStatistics();
    }
}
