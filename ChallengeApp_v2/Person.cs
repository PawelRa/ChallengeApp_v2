namespace ChallengeApp_v2
{
    public class Person
    {
        public Person()
        {
            this.Name = "no name";
        }


        public Person(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
