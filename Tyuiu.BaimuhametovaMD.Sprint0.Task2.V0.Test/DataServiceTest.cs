using Tyuiu.BaimuhametovaMD.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Мадина";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Мадина", res);
        }
    }
}