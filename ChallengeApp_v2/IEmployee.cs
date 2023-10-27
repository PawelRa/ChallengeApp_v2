using static ChallengeApp_v2.EmployeeBase;

namespace ChallengeApp_v2
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        void AddGrade(float grade);

        void AddGrade(double grade);

        void AddGrade(int grade);

        void AddGrade(string grade);

        void AddGrade(char grade);

        event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics();
    }
}
