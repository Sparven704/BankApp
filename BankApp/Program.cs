namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            


            int userPinInputTries = 3;

            var userOne = new UserAccount(1111, "Arv", new BankAccount("Main account", 2000), new BankAccount("Savings account", 50000));
            var userTwo = new UserAccount(2222, "Peter", new BankAccount("Main account", 300), new BankAccount("Savings account", 3000));
            var userThree = new UserAccount(3333, "Paul", new BankAccount("Main account", 60000), new BankAccount("Savings account", 600000));
            var userFour = new UserAccount(4444, "Steve", new BankAccount("Main account", 25000), new BankAccount("Savings account", 2000));
            var userFive = new UserAccount(5555, "Sparven", new BankAccount("Main account", 100000), new BankAccount("Savings account", 7000000));

            //Loop that controls the entire program to run, when this loop stops the program stops 
            while (userPinInputTries > 0)
            {

                Console.WriteLine("Hello and welcome to ArvBank! Please enter your 4 number pin-code below.");
                Console.WriteLine("Pin-code: ");
                string userPinInput = Console.ReadLine();



                switch (userPinInput)
                {
                    case "1111":
                        userPinInputTries = 3;
                        userOne.BuildUI(userOne);

                        break;
                    case "2222":
                        userPinInputTries = 3;
                        userTwo.BuildUI(userTwo);

                        break;
                    case "3333":
                        userPinInputTries = 3;
                        userThree.BuildUI(userThree);
                        break;

                    case "4444":
                        userPinInputTries = 3;
                        userFour.BuildUI(userFour);
                        break;
                    case "5555":
                        userPinInputTries = 3;
                        userFive.BuildUI(userFive);
                        break;
                    default:
                        Console.WriteLine("Wrong pincode");
                        userPinInputTries--;
                        break;
                }





            }
            
        }
    }
}




