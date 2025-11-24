namespace Tyuiu.TikhomirovaKA.Sprint5.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = Path.GetTempFileName();
            FileInfo fileinfo = new FileInfo(path);
            bool wait = true;
            Assert.AreEqual(wait, fileinfo.Exists);
        }
    }
}
