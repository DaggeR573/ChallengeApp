namespace PierwszaAplikacja
{
    public class Employee
    {

        public List<int> grades = new List<int>();

        public Employee(string firstName, string secondName, int age) 
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;

        }
        
        public string FirstName { get; private set; }

        public string SecondName { get; private set; }

        public int Age { get; private set; }

        public int Result
        { 
            get
            {
                return grades.Sum();
            }

        }

        public void AddGrade(int grade)
        {
            this.grades.Add(grade);
        }

    }

}
