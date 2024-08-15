//namespace PierwszaAplikacja.Tests
//{
//    public class EmployeeTests
//    {

//        [Test]
//        public void WhenThreeGradesAdded_ThenCheckMax()
//        {

//            //arrange
//            Employee employee = new Employee("Miko³aj", "Szulc");
//            employee.AddGrade(10);
//            employee.AddGrade(2);
//            employee.AddGrade(3);

//            //act
//            var statistics = employee.GetStatistics();

//            //assert
//            Assert.AreEqual(10, statistics.Max);
//        }

//        [Test]
//        public void WhenThreeGradesAdded_ThenReturnMin()
//        {

//            //arrange
//            Employee employee = new Employee("Miko³aj", "Szulc");
//            employee.AddGrade(10);
//            employee.AddGrade(2);
//            employee.AddGrade(3);

//            //act
//            var statistics = employee.GetStatistics();

//            //assert
//            Assert.AreEqual(2, statistics.Min);
//        }

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
//}