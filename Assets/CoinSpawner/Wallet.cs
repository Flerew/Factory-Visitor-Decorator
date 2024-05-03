namespace Assets.CoinSpawner
{
    public class Wallet
    {
        public int Money { get; private set; }

        public Wallet(int startMoney = 0) 
        { 
            Money = startMoney;
        }

        public void AddMoney(int value)
        {
            Money += value;
        }
    }
}