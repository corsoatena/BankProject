using System;
using System.IO;
using BankEnd;

namespace ApiProxy
{
    public class WebApiProxy
    {
       Bank _bank { get; set; }

        public WebApiProxy()
        {

            _bank = new Bank();
            _bank.Withdraw();
        }
    } 
    public class WebApp 
    { 
    }
    public class AtmApp 
    { 
        
        public string GetSaldo()
        {  
          return  File.ReadAllText(@"C:\Users\bruno\source\repos\Bank.Project\ApiProxy\data.json"); 
        }
    }
}
