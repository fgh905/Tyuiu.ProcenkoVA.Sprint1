using System;
using Tyuiu.ProcenkoVA.Sprint1.Task0.V1.Lib;

namespace Tyuiu.ProcenkoVA.Sprint1.Task0.V1.Test
{
    public class DataServiceTest
    {
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double wait = -6.0;
            var res = ds.Calculate();
        }
    }
}