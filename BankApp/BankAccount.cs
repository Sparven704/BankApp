using System.Text;

namespace BankApp
{
    public class BankAccount
    {
        public string accountNumber { get; }

        public string accountName { get; set; }
        //the balance of each account is calculated through adding the sum of each item.Amount inside the list allTransactions.
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();
        public BankAccount(string name, decimal initialBalance)
        {
            accountName = name;

            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

            accountNumber = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {   //making sure you cannot deposit a negative number
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positiv");
                
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {   //making sure you cannot withdaw a negative amount making it a double -- aka a +.
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positiv");
                
            }
            //making sure you cannot subtract a greater number than what is stored on Balance
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
        
        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            report.AppendLine("Date\t\tAmount\tNote");
            foreach (var item in allTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }
            return report.ToString();
        }
    }
}
