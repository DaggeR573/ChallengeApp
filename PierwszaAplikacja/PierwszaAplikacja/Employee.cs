namespace PierwszaAplikacja
{
    public class Employee
    {
       
        private List<float> grades = new List<float>();
        
        public Employee(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }

        public string FirstName { get; private set; }

        public string SecondName { get; private set; }

        public void AddGrade(float grade)
        {
            //Rzutowanie (casting)
            int valueInInt = (int)Math.Ceiling(grade);


            //WALIDACJA DANYCH
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {

            if (float.TryParse(grade, out float result))
            {
                this.grades.Add(result);
            }
            else
            {
                Console.WriteLine("String is not float.");
            }
        }
        public void AddGrade(double grade)
        {
            Console.WriteLine("Double variable, possible lack of precision");
            float value = (float)grade;
            this.AddGrade(value);
        }
        public void AddGrade(long grade)
        {
            Console.WriteLine("Long variable, possible lack of precision");
            float value = (float)grade;
            this.AddGrade(value);
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

            return statistics;
        }
    }

}
