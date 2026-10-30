using Tyuiu.ProcenkoVA.Sprint1.Task7.V22.Lib;

namespace Tyuiu.ProcenkoVA.Sprint1.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.5;
            double wait = 1.235;

            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}

