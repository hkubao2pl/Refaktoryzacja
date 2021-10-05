namespace Refaktoryzacja
{
    class Client
    {
        public int Id;

        public string Type;

        public double Balance;

        public Client(int id, string type, double balance)
        {
            Id = id;
            Type = type;
            Balance = balance;
        }

        public string DoOperation(string akcja, double kwota)
        {
            string result = string.Empty;
            if (akcja == "wp")
            {
                if (Type == "vip")
                {
                    Balance += kwota;
                    result = "Saldo: " + Balance;
                }
                else if (Type == "gold")
                {
                    Balance += kwota - 1;
                    result = "Saldo: " + Balance;
                }
                else
                {
                    Balance += kwota - 2;
                    result = "Saldo: " + Balance;
                }
            }
            else if (akcja == "wy")
            {
                if (Type == "vip")
                {
                    Balance -= kwota;
                    result = "Saldo: " + Balance;
                }
                else if (Type == "gold")
                {
                    if (Balance - kwota >= -1000)
                    {
                        Balance -= kwota;
                        result = "Saldo: " + Balance;
                    }
                    else
                    {
                        result = "Brak środków na koncie!!!";
                    }
                }
                else
                {
                    if (Balance - kwota - 1 >= 0)
                    {
                        Balance -= kwota + 1;
                        result = "Saldo: " + Balance;
                    }
                    else
                    {
                        result = "Brak środków na koncie!!!";
                    }
                }
            }

            return result;
        }
    }
}
