using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment2;
using Moq;
using System.Threading.Tasks;
using System.Threading;
namespace UnitTestProject2
{
    [TestClass]
    public class Assignment2Tests
    {
        [TestMethod]
        public async Task TestRefreshAmountAsync()
        {
            var moqAccountService = new Mock<IAccountService>();
            moqAccountService.Setup(x => x.GetAccountAmount(1)).ReturnsAsync(10.00);
            var account = new AccountInfo(1, moqAccountService.Object);
            await account.RefreshAmount();
            Assert.AreEqual(10.00, account.Amount);
        }
    }
}
