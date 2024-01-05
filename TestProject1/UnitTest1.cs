namespace TestProject1
{
    using NUnit.Framework;

    public class MinKlasse
    {
        public int LeggSammen(int a, int b)
        {
            return a + b;
        }
    }

    [TestFixture]
    public class MinKlasseTester
    {
        [Test]
        public void LeggSammen_GittToVerdier_ReturnererSummen()
        {
            MinKlasse test = new MinKlasse();
            int result = test.LeggSammen(3, 4);
            Assert.AreEqual(7, result);
        }
    }
}