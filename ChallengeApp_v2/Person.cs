namespace ChallengeApp_v2
{
    public class Person
    {
        public Person(string name, string surname, char sex = 'M')
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }
    }
}
