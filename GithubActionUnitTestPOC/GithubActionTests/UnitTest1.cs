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

            Assert.AreEqual(1, bank.CurrentMoney, "Money is correctlyChanged");

            bank.SubstractMoney(1);

            Assert.AreEqual(0, bank.CurrentMoney, "Money is correctlyChanged");

        }
    }
}