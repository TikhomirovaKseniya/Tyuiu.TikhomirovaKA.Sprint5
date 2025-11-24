namespace Tyuiu.TikhomirovaKA.Sprint5.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();
            FileInfo fileinfo = new FileInfo(path);
            bool wait = true;
            Assert.AreEqual(wait, fileinfo.Exists);
        }
    }
}
