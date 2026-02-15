using DemoTest;
using NUnit.Framework;

namespace DemoTest_Unit
{
    public class Tests
    {
        [Test]
        public void AddTwoPositiveNumbers()
        {
           var calk=new Calculator();

            int a = 4;
            int b = 12;

            int result = calk.Add(a,b);

            Assert.That(result, Is.EqualTo(16));
        }

        [Test]
        public void AddOnePositiveNumbers()
        {
            var calk = new Calculator();

            int a = 4;
            int b = -3;

            int result = calk.Add(a, b);

            Assert.That(result, Is.EqualTo(1));
        }
    }
}
