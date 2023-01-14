namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {


            var arv1 = new BankAccount("Main account", 2000);
            var arv2 = new BankAccount("Savings account", 10000);

            var peter1 = new BankAccount("Main account", 200);
            var peter2 = new BankAccount("Savings account", 400000);
            var peter3 = new BankAccount("Investments account", 1000);

            var paul1 = new BankAccount("Main account", 23000);
            var paul2 = new BankAccount("Savings account", 305000);
            var paul3 = new BankAccount("Investments account", 2000);
            var paul4 = new BankAccount("Pension account", 110000);

            var steven1 = new BankAccount("Main account", 2000);
            var steven2 = new BankAccount("Savings account", 79000);
            var steven3 = new BankAccount("Investments account", 2000);
            var steven4 = new BankAccount("Pension account", 800000);
            var steven5 = new BankAccount("Secret gambling account", 1000000);

            var sparven1 = new BankAccount("Main account", 1000000);
            var sparven2 = new BankAccount("Savings account", 20000000);
            var sparven3 = new BankAccount("Investments account", 3000000);
            var sparven4 = new BankAccount("Pension account", 10);
            var sparven5 = new BankAccount("Grandkids account", 2000);
            var sparven6 = new BankAccount("Mistress account", 400000);


            BankAccount[] arvAccounts = new BankAccount[2];
            arvAccounts[0] = arv1;
            arvAccounts[1] = arv2;

            BankAccount[] peterAccounts = new BankAccount[3];
            peterAccounts[0] = peter1;
            peterAccounts[1] = peter2;
            peterAccounts[2] = peter3;

            BankAccount[] paulAccounts = new BankAccount[4];
            paulAccounts[0] = paul1;
            paulAccounts[1] = paul2;
            paulAccounts[2] = paul3;
            paulAccounts[3] = paul4;

            BankAccount[] stevenAccounts = new BankAccount[5];
            stevenAccounts[0] = steven1;
            stevenAccounts[1] = steven2;
            stevenAccounts[2] = steven3;
            stevenAccounts[3] = steven4;
            stevenAccounts[4] = steven5;

            BankAccount[] sparvenAccounts = new BankAccount[6];
            sparvenAccounts[0] = sparven1;
            sparvenAccounts[1] = sparven2;
            sparvenAccounts[2] = sparven3;
            sparvenAccounts[3] = sparven4;
            sparvenAccounts[4] = sparven5;
            sparvenAccounts[5] = sparven6;


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




