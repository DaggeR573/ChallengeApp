namespace PierwszaAplikacja
{
    public class Employee
    {

        public List<int> points = new List<int>();

        public Employee(string firstName, string secondName, int age) 
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;

        }

        public Employee(string firstName)
        {
            this.FirstName = firstName;

        }

        public string FirstName { get; private set; }

        public string SecondName { get; private set; }

        public int Age { get; private set; }

        public int Result
        { 
            get
            {
                return points.Sum();
            }

        }

        public void AddPoints(int points)
        {
            this.points.Add(points);
        }

        public void RemovePoints(int points)
        {
            this.points.Add(-points);

        }

    }

}
