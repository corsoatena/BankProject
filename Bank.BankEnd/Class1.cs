using System;

namespace BankEnd
{
    public class Bank
    {
        BankAccount _account = new BankAccount();
        private class BankAccount
        {
            public void Withdraw()
            {
               
            }
        }
        public void Withdraw()
        {
            _account.Withdraw();
        }
        void GetLiquidity()
        {
            _account.Withdraw();
        }
    }    
}
    