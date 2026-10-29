using Tyuiu.ProcenkoVA.Sprint1.Task3.V17.Lib;

namespace Tyuiu.ProcenkoVA.Sprint1.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 123.405;
            bool wait = true;
            bool res = ds.ZeroCheck(number);
            Assert.AreEqual(wait, res);
        }
    }
}
