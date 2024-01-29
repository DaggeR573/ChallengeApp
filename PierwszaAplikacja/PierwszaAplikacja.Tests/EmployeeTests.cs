namespace PierwszaAplikacja.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenAddTwoSetOfPoints_ThenReturnFinalResult()
        {

            //arrange
            Employee employee = new Employee("Miko³aj", "Szulc", 25);
            employee.AddPoints(10);
            employee.AddPoints(2);
            

            //act
            var result = employee.Result;


            //assert
            Assert.AreEqual(12, result);
        }

    }
}