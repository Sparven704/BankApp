namespace BankApp
{
    public class UserAccount
    {
        public int pinCode { get; set; }
        public string userName { get; }

        public BankAccount accountOne { get; set; }

        public BankAccount accountTwo { get; set; }

        public UserAccount(int pin, string name, BankAccount one, BankAccount two)
        {
            pinCode = pin;
            userName = name;
            accountOne = one;
            accountTwo = two;
        }
        //I use this method to build the UI for each user after they have logged in
        public void BuildUI(UserAccount user)
        {
            bool programLoop = true;
            //This loop makes sure that this part of the program will loop for as long as the user is logged in. When they log out this loop stops and the main loop continues.
            while (programLoop == true)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine($"Hello {user.userName}!");
                Console.WriteLine();
                Console.WriteLine("1. View your accounts");
                Console.WriteLine("2. Transfer funds between accounts");
                Console.WriteLine("3. Withdraw money");
                Console.WriteLine("4. Deposit money");
                Console.WriteLine("5. Log out");
                Console.WriteLine();
                Console.WriteLine("Enter corresponding number to choose option: ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine($"{user.accountOne.accountName}; Account number {user.accountOne.accountNumber}; Balance: {user.accountOne.Balance} kr.");
                        Console.WriteLine();
                        Console.WriteLine($"{user.accountTwo.accountName}; Account number {user.accountTwo.accountNumber}; Balance: {user.accountTwo.Balance} kr.");
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine($"1. {user.accountOne.accountName}; Account number {user.accountOne.accountNumber}; Balance: {user.accountOne.Balance} kr.");
                        Console.WriteLine();
                        Console.WriteLine($"2. {user.accountTwo.accountName}; Account number {user.accountTwo.accountNumber}; Balance: {user.accountTwo.Balance} kr.");
                        Console.WriteLine();
                        Console.WriteLine("What account do you want to transfer money from? Write corresponding number:  ");
                        string userChoiceTransferFrom = Console.ReadLine();
                        Console.WriteLine("And what account do you want to transfer too? ");
                        string userChoiceTransferToo = Console.ReadLine();
                        Console.WriteLine("And lastly how much money do you want to transfer? ");
                        int userChoiceTransferAmount = Convert.ToInt32(Console.ReadLine());
                        if (userChoiceTransferFrom == "1")
                        {
                            user.accountOne.MakeWithdrawal(userChoiceTransferAmount, DateTime.Now, "Money Transfer");
                            user.accountTwo.MakeDeposit(userChoiceTransferAmount, DateTime.Now, "Money Transfer");

                        }
                        else if (userChoiceTransferFrom == "1")
                        {
                            user.accountTwo.MakeWithdrawal(userChoiceTransferAmount, DateTime.Now, "Money Transfer");
                            user.accountOne.MakeDeposit(userChoiceTransferAmount, DateTime.Now, "Money Transfer");
                        }
                        else
                        {
                            Console.WriteLine("Invalid option. Please try again: ");
                            userChoiceTransferFrom = Console.ReadLine();
                        }
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine("Your money has been transfered. New balances: ");
                        Console.WriteLine();
                        Console.WriteLine($"{user.accountOne.accountName}; Account number {user.accountOne.accountNumber}; Balance: {user.accountOne.Balance} kr.");
                        Console.WriteLine();
                        Console.WriteLine($"{user.accountTwo.accountName}; Account number {user.accountTwo.accountNumber}; Balance: {user.accountTwo.Balance} kr.");
                        break;
                    case "3":
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine($"1. {user.accountOne.accountName}; Account number {user.accountOne.accountNumber}; Balance: {user.accountOne.Balance} kr.");
                        Console.WriteLine();
                        Console.WriteLine($"2. {user.accountTwo.accountName}; Account number {user.accountTwo.accountNumber}; Balance: {user.accountTwo.Balance} kr.");
                        Console.WriteLine();
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("What account do you want to withdraw money from? Write corresponding number:  ");
                        string userChoiceWithdraw = Console.ReadLine();
                        Console.WriteLine("And how much money do you want to withdraw? ");
                        int userChoiceWithdrawAmount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (userChoiceWithdraw == "1")
                        {
                            user.accountOne.MakeWithdrawal(userChoiceWithdrawAmount, DateTime.Now, "Withdrawal");
                        }
                        else if (userChoiceWithdraw == "1")
                        {
                            user.accountTwo.MakeWithdrawal(userChoiceWithdrawAmount, DateTime.Now, "Withdrawal");
                        }
                        else
                        {
                            Console.WriteLine("Invalid option. Please try again: ");
                            userChoiceWithdraw = Console.ReadLine();
                        }
                        break;
                    case "4":
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine($"1. {user.accountOne.accountName}; Account number {user.accountOne.accountNumber}; Balance: {user.accountOne.Balance} kr.");
                        Console.WriteLine();
                        Console.WriteLine($"2. {user.accountTwo.accountName}; Account number {user.accountTwo.accountNumber}; Balance: {user.accountTwo.Balance} kr.");
                        Console.WriteLine();
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("What account do you want to withdraw money from? Write corresponding number:  ");
                        string userChoiceDeposit = Console.ReadLine();
                        Console.WriteLine("And how much money do you want to withdraw? ");
                        int userChoiceDepositAmount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (userChoiceDeposit == "1")
                        {
                            user.accountOne.MakeDeposit(userChoiceDepositAmount, DateTime.Now, "Deposit");
                        }
                        else if (userChoiceDeposit == "2")
                        {
                            user.accountTwo.MakeDeposit(userChoiceDepositAmount, DateTime.Now, "Deposit");
                        }
                        else
                        {
                            Console.WriteLine("Invalid option. Please try again: ");
                            userChoiceDeposit = Console.ReadLine();
                        }
                        break;
                    
                    case "5":
                        programLoop = false;

                        break;
                    default:
                        Console.WriteLine("Invalid command.");

                        break;

                }
            }
        }
    }
}
