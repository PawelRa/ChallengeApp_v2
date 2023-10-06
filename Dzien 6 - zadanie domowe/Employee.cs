namespace Dzien_6___zadanie_domowe
{
    public class Employee
    {
        private List<int> scores = new List<int>();

        public Employee(string name, string surname, int age) {
            this.Age = age; 
            this.Name = name; 
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int Result { get {  return scores.Sum(); } }

        public void AddScore(int score)
        {
            scores.Add(score);
        }

    }
}
