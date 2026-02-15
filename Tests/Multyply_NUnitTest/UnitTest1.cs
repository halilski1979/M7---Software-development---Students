using DemoTest;

namespace Multyply_NUnitTest
{
    public class Tests
    {
       

        [Test]
        public void MultyplyTwoNumbers()
        {
            Multyply m = new Multyply();

            double a = 4;
            double b = 5;

            double result = m.MultyplyNumbers(a,b);

            Assert.AreEqual(20, result);           
        }

        [Test]
        public void MultyplyNegativeNumbers()
        {
            Multyply m = new Multyply();

            double a = -4;
            double b = 5;

            double result = m.MultyplyNumbers(a, b);

            Assert.AreEqual(-20, result);
        }

        [Test]
        public void MultyplyWithZerrou()
        {
            Multyply m = new Multyply();

            double a = 0;
            double b = 5;

            double result = m.MultyplyNumbers(a, b);

            Assert.AreEqual(0, result);
        }
    }
}