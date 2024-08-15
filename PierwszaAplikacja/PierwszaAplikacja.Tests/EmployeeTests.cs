namespace PierwszaAplikacja.Tests
{



    public class EmployeeTests
    {

        [Test]
        public void WhenLetterPassed_ThenCheckAverageLetter()
        {

            //arrange
            Employee employee = new Employee("Miko³aj", "Szulc");
            employee.AddGrade('A');
            employee.AddGrade('B');
            employee.AddGrade('C');
            employee.AddGrade('D');
            employee.AddGrade('E');

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual('B', statistics.AverageLetter);
        }

        [Test]
        public void WhenGradesAdded_ThenCheckAverage()
        {

            //arrange
            Employee employee = new Employee("Miko³aj", "Szulc");
            employee.AddGrade(100);
            employee.AddGrade(30);
            employee.AddGrade(50);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(60, statistics.Average);
        }

        //        [Test]
        //        public void WhenThreeGradesAdded_ThenReturnAverageOfThem()
        //        {

        //            //arrange
        //            Employee employee = new Employee("Miko³aj", "Szulc");
        //            employee.AddGrade(10);
        //            employee.AddGrade(2);
        //            employee.AddGrade(3);

        //            //act
        //            var statistics = employee.GetStatistics();

        //            //assert
        //            Assert.AreEqual(5, statistics.Average);
        //        }

        //    }
    }
}