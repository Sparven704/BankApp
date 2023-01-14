namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an array for each user and create their bank accounts inside each array
            BankAccount[] arvAccounts = new BankAccount[2];
            arvAccounts[0] = new BankAccount("Main account", 2000);
            arvAccounts[1] = new BankAccount("Savings account", 10000);

            BankAccount[] peterAccounts = new BankAccount[3];
            peterAccounts[0] = new BankAccount("Main account", 200);
            peterAccounts[1] = new BankAccount("Savings account", 400000);
            peterAccounts[2] = new BankAccount("Investments account", 1000);

            BankAccount[] paulAccounts = new BankAccount[4];
            paulAccounts[0] = new BankAccount("Main account", 23000);
            paulAccounts[1] = new BankAccount("Savings account", 305000);
            paulAccounts[2] = new BankAccount("Investments account", 2000);
            paulAccounts[3] = new BankAccount("Pension account", 110000);

            BankAccount[] stevenAccounts = new BankAccount[5];
            stevenAccounts[0] = new BankAccount("Main account", 2000);
            stevenAccounts[1] = new BankAccount("Savings account", 79000);
            stevenAccounts[2] = new BankAccount("Investments account", 2000);
            stevenAccounts[3] = new BankAccount("Pension account", 800000);
            stevenAccounts[4] = new BankAccount("Secret gambling account", 1000000);

            BankAccount[] sparvenAccounts = new BankAccount[6];
            sparvenAccounts[0] = new BankAccount("Main account", 1000000);
            sparvenAccounts[1] = new BankAccount("Savings account", 20000000);
            sparvenAccounts[2] = new BankAccount("Investments account", 3000000);
            sparvenAccounts[3] = new BankAccount("Pension account", 10);
            sparvenAccounts[4] = new BankAccount("Grandkids account", 2000);
            sparvenAccounts[5] = new BankAccount("Mistress account", 400000);

            //Here I create each user and assign corresponding array with bank accounts
            var arv = new UserAccount("1111", "Arv", arvAccounts);
            var peter = new UserAccount("2222", "Peter", peterAccounts);
            var paul = new UserAccount("3333", "Paul", paulAccounts);
            var steven = new UserAccount("4444", "Steve", stevenAccounts);
            var sparven = new UserAccount("5555", "Sparven", sparvenAccounts);


            int userPinTries = 3;

            //Loop that controls the entire program to run, when this loop stops the program stops 
            while (userPinTries > 0)
            {

                Console.WriteLine("Hello and welcome to ArvBank! Please enter your 4 number pin-code below.");
                Console.WriteLine("Pin-code: ");
                string userPinInput = Console.ReadLine();

                if (userPinInput == arv.pinCode)
                {
                    //when you succesfully log in to a user account the log in attempts reset
                    userPinTries = 3;
                    //my method that builds the ui
                    arv.BuildUI(arv);
                }
                else if (userPinInput == peter.pinCode)
                {
                    userPinTries = 3;
                    peter.BuildUI(peter);
                }
                else if (userPinInput == paul.pinCode)
                {
                    userPinTries = 3;
                    paul.BuildUI(paul);
                }
                else if (userPinInput == steven.pinCode)
                {
                    userPinTries = 3;
                    steven.BuildUI(steven);
                }
                else if (userPinInput == sparven.pinCode)
                {
                    userPinTries = 3;
                    sparven.BuildUI(sparven);
                }
                else
                {
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("Wrong pincode.");
                    Console.WriteLine("---------------------------------------------------------");
                    userPinTries--;
                }

            }
            Console.WriteLine("Too many wrong attempts, you have been locked out. Terminating machine in 3..2..1..");
        }
    }
}




