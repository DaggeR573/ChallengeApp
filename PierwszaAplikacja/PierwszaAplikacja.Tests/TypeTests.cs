namespace PierwszaAplikacja.Tests
{
    public class TypeTests
    {

        [Test]
        public void WhenTwoStringsAreGiven_ThenCheckTheirInequality()
        {

            // arrange
            string string1 = "Mikołaj";
            string string2 = "Kamil";

            // act

            // assert
            Assert.AreNotEqual(string1, string2);
        }

        [Test]
        public void WhenTwoCharsAreGiven_ThenCheckTheirInequality()
        {

            // arrange
            char char1 = 'A';
            char char2 = 'B';

            // act

            // assert
            Assert.AreNotEqual(char1, char2);
        }


        [Test]
        public void WhenTwoIntsAreGiven_ThenCheckTheirInequality()
        {

            // arrange
            int int1 = 1;
            int int2 = 2;

            // act

            // assert
            Assert.AreNotEqual(int1, int2);
        }

        [Test]
        public void WhenTwoFloatsAreGiven_ThenCheckTheirInequality()
        {

            // arrange
            float float1 = 2342342522234346345;
            float float2 = 9592342934239242342;

            // act

            // assert
            Assert.AreNotEqual(float1, float2);
        }

        [Test]
        public void WhenTwoDoublesAreGiven_ThenCheckTheirInequality()
        {

            // arrange
            double double1 = 1.252;
            double double2 = 554.2342;

            // act

            // assert
            Assert.AreNotEqual(double1, double2);
        }


        [Test]
        public void WhenTwoLongsAreGiven_ThenCheckTheirEquality()
        {

            // arrange
            long long1 = 1232345343636456457;
            long long2 = 1232345343636456457;

            // act

            // assert
            Assert.AreEqual(long1, long2);
        }
    }
}
