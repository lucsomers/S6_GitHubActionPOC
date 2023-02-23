namespace GithubActionTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bank bank = new Bank();

            bank.AddMoney(1);

            Assert.AreEqual(1, bank.CurrentMoney);
            Assert.AreEqual(2, bank.CurrentMoney);
        }
    }
}