using MathProject;
//using System.Runtime.CompilerServices;
//[assembly: InternalsVisibleTo("MathProject")] //I stedet for at gøre klassen public


namespace MathUnitTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestAdd()
        {
            //Arrange
            Calculator calculator = new MathProject.Calculator();
            int first = 5;
            int second = 10;
            int expected = 15;

            //Act
            int actual = calculator.Add(first, second);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddCollection()
        {
            //Arrange
            Calculator calculator = new MathProject.Calculator();
            List<int> expected = new List<int>(new int[] {16, 10});

            //Act
            calculator.Add(13, 3);
            calculator.Add(9, 1);

            //Assert
            CollectionAssert.AreEqual(expected, calculator.Results);
        }

        //Testing positive number branch

        [TestMethod]
        public void TestNumberIsPositive()
        {
            //Arrange
            Calculator calculator = new MathProject.Calculator();
            int number = 10;
            bool expected = true;

            //Act
            bool actual = calculator.NumberIsPositive(number);

            //Assert
            Assert.AreEqual(expected, actual);
            //Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestNumberIsZero()
        {
            //Arrange
            Calculator calculator = new MathProject.Calculator();
            int number = 0;
            bool expected = false;

            //Act
            bool actual = calculator.NumberIsPositive(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNumberIsNegative()
        {
            //Arrange
            Calculator calculator = new MathProject.Calculator();
            int number = -10;
            bool expected = false;

            //Act
            bool actual = calculator.NumberIsPositive(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        //Testing even mnumber branch

        [TestMethod]
        public void TestNumberIsEven()
        {
            //Arrange
            Calculator calculator = new MathProject.Calculator();
            int number = 10;
            bool expected = true;

            //Act
            bool actual = calculator.NumberIsEven(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNumberIsNotEven()
        {
            //Arrange
            Calculator calculator = new MathProject.Calculator();
            int number = 11;
            bool expected = false;

            //Act
            bool actual = calculator.NumberIsEven(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
