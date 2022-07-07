using System;

namespace Bank.Project
{
    public abstract class Intermediate: ICentralBank
    {
        public abstract void Manage(Product product); 
    }
    public class Bank : Intermediate
    {
        public override void Manage(Product Liquidity)
        {
            Liquidity liquidity = (Liquidity)Liquidity;
            Withdraw(liquidity.Amount);
        }
        public void Withdraw(String Amount)
        {
            Console.WriteLine($"Prelevato {Amount}  tramite Banca");
        }
    }
    public class Borsa : Intermediate
    {

        public override void Manage(Product stock)
        {
            Sell();
        }
        public void Sell()
        {
            Console.WriteLine("Vendo azioni");
        }
    }

}
