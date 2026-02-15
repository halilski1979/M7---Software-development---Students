using DemoTest;

namespace Multyply_MSTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
        }

        [TestMethod]
        public void MultyplyTwoNumbers()
        {
            //Arrange
            Multyply m=new Multyply();

            int a = 5;
            int b = 6;

            //Act
            double result = m.MultyplyNumbers(a,b);

            //Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void MultyplyNegativeNumbers()
        {
            //Arrange
            Multyply m = new Multyply();

            int a = -5;
            int b = 6;

            //Act
            double result = m.MultyplyNumbers(a, b);

            //Assert
            Assert.AreEqual(-30, result);
        }
    }
}
