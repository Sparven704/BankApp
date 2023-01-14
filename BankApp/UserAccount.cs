namespace BankApp
{
    public class UserAccount
    {
        public string pinCode { get; set; }
        public string userName { get; }

        public BankAccount[] userAccounts { get; set; }

        public UserAccount(string pin, string name, BankAccount[] accounts)
        {
            userAccounts = accounts;
            pinCode = pin;
            userName = name;

        }
        //I use this method to build the UI for each user after they have logged in
        public void BuildUI(UserAccount user)
        {
            bool programLoop = true;
            //This loop makes sure that this part of the program will loop for as long as the user is logged in. When they log out this loop stops and the main loop continues.
            while (programLoop == true)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine($"Hello {user.userName}!");
                Console.WriteLine();
                Console.WriteLine("1. View your accounts");
                Console.WriteLine("2. Transfer funds between accounts");
                Console.WriteLine("3. Withdraw money");
                Console.WriteLine("4. Deposit money");
                Console.WriteLine("5. Transaction history");
                Console.WriteLine("6. Log out");
                Console.WriteLine();
                Console.WriteLine("Enter corresponding number to choose option: ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine();
                        //loops through the selected users bank accounts and writes out all of the different accounts and whats inside of them
                        for (int i = 0; i < user.userAccounts.Length; i++)
                        {
                            Console.WriteLine($"{user.userAccounts[i].accountName}; Account number {user.userAccounts[i].accountNumber}; Balance: {user.userAccounts[i].Balance} kr.");
                            Console.WriteLine();
                        }

                        //lines to make the program wait until you press a key to restart the loop
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("---------------------------------------------------------");
                        for (int i = 0; i < user.userAccounts.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {user.userAccounts[i].accountName}; Account number {user.userAccounts[i].accountNumber}; Balance: {user.userAccounts[i].Balance} kr.");
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine("What account do you want to transfer money from? Write corresponding number:  ");
                        int userChoiceTransferFrom = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("And what account do you want to transfer too? ");
                        int userChoiceTransferToo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("And lastly how much money do you want to transfer? ");
                        int userChoiceTransferAmount = Convert.ToInt32(Console.ReadLine());
                        int fromIndex = userChoiceTransferFrom - 1;
                        int toIndex = userChoiceTransferToo - 1;


                        // making sure you can't select a higher or lower number than amount of accounts.
                        if (userChoiceTransferFrom > user.userAccounts.Length | userChoiceTransferToo > user.userAccounts.Length)
                        {
                            Console.WriteLine("Invalid option. Press any key to return to menu ");
                            Console.ReadKey();
                        }
                        else if (userChoiceTransferFrom <= 0 | userChoiceTransferToo <= 0)
                        {
                            Console.WriteLine("Invalid option. Press any key to return to menu ");
                            Console.ReadKey();
                        }
                        else
                        {
                            user.userAccounts[fromIndex].MakeWithdrawal(userChoiceTransferAmount, DateTime.Now, "Money Transfer");
                            user.userAccounts[toIndex].MakeDeposit(userChoiceTransferAmount, DateTime.Now, "Money Transfer");

                            Console.WriteLine("---------------------------------------------------------");
                            Console.WriteLine("Your money has been transfered. New balances: ");
                            Console.WriteLine();

                            for (int i = 0; i < user.userAccounts.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. {user.userAccounts[i].accountName}; Account number {user.userAccounts[i].accountNumber}; Balance: {user.userAccounts[i].Balance} kr.");
                                Console.WriteLine();
                            }


                            Console.WriteLine("---------------------------------------------------------");
                            Console.WriteLine("Press any key to return to menu");
                            Console.ReadKey();
                        }
                        break;
                    case "3":
                        Console.WriteLine("---------------------------------------------------------");
                        for (int i = 0; i < user.userAccounts.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {user.userAccounts[i].accountName}; Account number {user.userAccounts[i].accountNumber}; Balance: {user.userAccounts[i].Balance} kr.");
                            Console.WriteLine();
                        }
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("What account do you want to withdraw money from? Write corresponding number:  ");
                        int userChoiceWithdraw = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("And how much money do you want to withdraw? ");
                        int userChoiceWithdrawAmount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        int withdrawIndex = userChoiceWithdraw - 1;



                        if (userChoiceWithdraw > user.userAccounts.Length)
                        {
                            Console.WriteLine("Invalid option. Press any key to return to menu ");
                            Console.ReadKey();
                        }
                        else if (userChoiceWithdraw <= 0)
                        {
                            Console.WriteLine("Invalid option. Press any key to return to menu ");
                            Console.ReadKey();
                        }
                        else
                        {
                            user.userAccounts[withdrawIndex].MakeWithdrawal(userChoiceWithdrawAmount, DateTime.Now, "Money withdrawal");

                            Console.WriteLine("---------------------------------------------------------");
                            Console.WriteLine("Your money has been Withdrawn. New balances: ");
                            Console.WriteLine();

                            for (int i = 0; i < user.userAccounts.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. {user.userAccounts[i].accountName}; Account number {user.userAccounts[i].accountNumber}; Balance: {user.userAccounts[i].Balance} kr.");
                                Console.WriteLine();
                            }


                            Console.WriteLine("---------------------------------------------------------");
                            Console.WriteLine("Press any key to return to menu");
                            Console.ReadKey();
                        }
                        break;
                    case "4":
                        Console.WriteLine("---------------------------------------------------------");
                        for (int i = 0; i < user.userAccounts.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {user.userAccounts[i].accountName}; Account number {user.userAccounts[i].accountNumber}; Balance: {user.userAccounts[i].Balance} kr.");
                            Console.WriteLine();
                        }
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("What account do you want to deposit money to? Write corresponding number:  ");
                        int userChoiceDeposit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("And how much money do you want to deposit? ");
                        int userChoiceDepositAmount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        int DepositIndex = userChoiceDeposit - 1;



                        if (userChoiceDeposit > user.userAccounts.Length)
                        {
                            Console.WriteLine("Invalid option. Press any key to return to menu ");
                            Console.ReadKey();
                        }
                        else if (userChoiceDeposit <= 0)
                        {
                            Console.WriteLine("Invalid option. Press any key to return to menu ");
                            Console.ReadKey();
                        }
                        else
                        {
                            user.userAccounts[DepositIndex].MakeDeposit(userChoiceDepositAmount, DateTime.Now, "Money deposit");

                            Console.WriteLine("---------------------------------------------------------");
                            Console.WriteLine("Your money has been Deposited. New balances: ");
                            Console.WriteLine();

                            for (int i = 0; i < user.userAccounts.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. {user.userAccounts[i].accountName}; Account number {user.userAccounts[i].accountNumber}; Balance: {user.userAccounts[i].Balance} kr.");
                                Console.WriteLine();
                            }


                            Console.WriteLine("---------------------------------------------------------");
                            Console.WriteLine("Press any key to return to menu");
                            Console.ReadKey();
                        }
                        break;

                    case "5":
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine();
                        for (int i = 0; i < user.userAccounts.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {user.userAccounts[i].accountName}; Account number {user.userAccounts[i].accountNumber}; Balance: {user.userAccounts[i].Balance} kr.");
                            Console.WriteLine();
                        }
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine($"Type the corresponding number to select the account you want to see your transaction history on. Or typ {user.userAccounts.Length + 1} to see for all accounts. ");
                        int userChoiceTransactions = Convert.ToInt32(Console.ReadLine());
                        int transactionIndex = userChoiceTransactions - 1;
                        if (userChoiceTransactions == user.userAccounts.Length + 1)
                        {
                            
                            for (int i = 0; i < user.userAccounts.Length; i++)
                            {
                                Console.WriteLine("---------------------------------------------------------");
                                Console.WriteLine($"{i + 1}. {user.userAccounts[i].accountName}; Account number {user.userAccounts[i].accountNumber}");
                                Console.WriteLine("---------------------------------------------------------");
                                Console.WriteLine(user.userAccounts[i].GetAccountHistory());
                                Console.WriteLine("---------------------------------------------------------");
                                Console.WriteLine();
                            }
                            Console.WriteLine("Press any key to return to menu");
                            Console.ReadKey();
                        }
                        else if (userChoiceTransactions <= 0)
                        {
                            Console.WriteLine("---------------------------------------------------------");
                            Console.WriteLine("Invalid option. Press any key to return to menu ");
                            Console.ReadKey();

                        }
                        else if (userChoiceTransactions > user.userAccounts.Length + 1)
                        {
                            Console.WriteLine("---------------------------------------------------------");
                            Console.WriteLine("Invalid option. Press any key to return to menu ");
                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine("---------------------------------------------------------");
                            Console.WriteLine(user.userAccounts[transactionIndex].GetAccountHistory());
                            Console.WriteLine("---------------------------------------------------------");
                            Console.WriteLine("Press any key to return to menu");
                            Console.ReadKey();
                        }
                        break;
                    case "6":
                        programLoop = false;
                        break;
                    default:
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine("Invalid command.");
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        break;

                }
            }
        }
    }
}
