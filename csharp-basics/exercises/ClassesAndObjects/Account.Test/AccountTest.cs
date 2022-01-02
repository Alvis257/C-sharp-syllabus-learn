using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Account.Test
{
    [TestClass]
    public class AccountTest
    {
        private Account _target = new Account("Bill", 0);
        private Account _target2 = new Account("Alex", 100);

        [TestMethod]
        public void ToString_Should_Return_Name_Bill_And_Balance_0()
        {
            //Assert
            Assert.AreEqual($"Bill: 0",_target.ToString());
        }

        [TestMethod]
        public void Transfer_Should_Transfer_Money_From_target_To_target2()
        {
            //Arrange
            int quantity = 100;

            //Act
            Account.Transfer(_target2,_target,quantity);

            //Assert
            Assert.AreEqual($"Bill: 100", _target.ToString());
            Assert.AreEqual($"Alex: 0", _target2.ToString());
        }

        [TestMethod]
        public void Withdraw_Should_Withdraw_100_From_target2()
        {
            //Arrange
            int quantity = 100;
            //Assert
            Assert.AreEqual(0, _target2.Withdrawal(quantity));
        }

        [TestMethod]
        public void Balance_Should_Show_Balance_target_0_target2_100()
        {
            //Assert
            Assert.AreEqual(100, _target2.Balance());
            Assert.AreEqual(0, _target.Balance());
        }
    }
}
