using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
using Moq;
namespace UnitTestProject1
{
    [TestClass]
    public class Assignment1Tests
    {
        [TestMethod]
        public void TestRefreshAmount()
        {
            var moqAccountService = new Mock<IAccountService>();
            moqAccountService.Setup(x=>x.GetAccountAmount(1)).Returns(10.00);
            var account = new AccountInfo(1, moqAccountService.Object);

            account.RefreshAmount();
            Assert.AreEqual(10.00, account.Amount);
        }
    }
}
