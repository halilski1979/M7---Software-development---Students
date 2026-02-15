using DemoTest;

namespace MSTestDemo
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void SumTwoNumbers()
        {
            var calk=new Calculator();

            int a = 5;
            int b = 2;

            int result=calk.Add(a, b);

            Assert.AreEqual(7, result);

        }


        [TestMethod]
        public void SumOneNegativeNumbers()
        {
            var calk = new Calculator();

            int a = 5;
            int b = -2;

            int result = calk.Add(a, b);

            Assert.AreEqual(4, result);

        }
    }
}
