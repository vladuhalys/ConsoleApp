namespace TestConsoleApp
{
    [TestClass]
    public class UnitTestModel
    {
        [TestMethod]
        public void Test1()
        {
            //Act
            string result = Core.Model.GetHelloWorld();
            //Assert
            Assert.AreEqual("Hello, World!", result);
        }
    }
}