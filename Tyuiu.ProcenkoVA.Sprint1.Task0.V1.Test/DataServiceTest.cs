namespace Tyuiu.ProcenkoVA.Sprint1.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private object? Assert;

        [TestMethod]
        public void TestMethod1()
        {
            DataServiceTest ds = new DataServiceTest();
            var res = ds.Calculate();
            object value = Assert.AreEqual(2, res);
        }

        private int Calculate()
        {
            throw new NotImplementedException();
        }
    }

    internal class TestClassAttribute : Attribute
    {
    }

    internal class TestMethodAttribute : Attribute
    {
    }
}
