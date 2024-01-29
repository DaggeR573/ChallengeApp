namespace PierwszaAplikacja.Tests
{
    public class Tests
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

        [Test]
        public void WhenRemoveTwoSetOfPoints_ThenReturnFinalResult()
        {

            //arrange
            Employee employee = new Employee("Miko³aj", "Szulc", 25);
            employee.RemovePoints(10);
            employee.RemovePoints(10);


            //act
            var result = employee.Result;


            //assert
            Assert.AreEqual(-20, result);
        }

        [Test]
        public void WhenAddOrRemoveTwoSetOfPoints_ThenReturnFinalResult()
        {

            //arrange
            Employee employee = new Employee("Miko³aj", "Szulc", 25);
            employee.AddPoints(10);
            employee.RemovePoints(2);


            //act
            var result = employee.Result;


            //assert
            Assert.AreEqual(8, result);
        }
    }
}