namespace Tyuiu.TikhomirovaKA.Sprint5.Task1.V16.Test
{
    [TestClass]
    public sealed class Test1
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
