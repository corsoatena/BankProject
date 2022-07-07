namespace Bank.Project
{
    public abstract class Product
    {
    }
    public class Stock : Product
    {

    }
    public class Liquidity : Product
    {

        decimal _amount;
        FIAT _currency;
        public string Amount { get { return $"{_amount} {_currency}"; } }
        public Liquidity(decimal Total, FIAT Currency)
        {
            _amount = Total;
            _currency = Currency;
        }
    }
}
