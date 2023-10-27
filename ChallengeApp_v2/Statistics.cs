namespace ChallengeApp_v2
{
    public class Statistics
    {
        public float Min { get; private set; }

        public float Max { get; private set; }

        public float Sum { get; private set; }

        public int Count { get; private set; }

        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }

        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 100:
                        return 'A';
                    case var average when average >= 80:
                        return 'B';
                    case var average when average >= 60:
                        return 'C';
                    case var average when average >= 40:
                        return 'D';
                    case var average when average >= 20:
                        return 'E';
                    default:
                        return 'F';

                }
            }
        }

        public Statistics()
        {
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
            this.Sum = 0;
            this.Count = 0;
        }


        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(this.Min, grade);
            this.Max = Math.Max(this.Max, grade);
        }
    }
}
