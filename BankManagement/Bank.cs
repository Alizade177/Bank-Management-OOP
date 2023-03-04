using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public class Bank
    {
        public Bank(string name)
        {
            this.Name = name;   
            Customers = new List<Customer>();
        }

        public string Name { get; set; }
        public List<Customer> Customers { get; set; }
        private bool isEnd;

        public void Start()
        {
            Console.WriteLine($"*****##### WELCOME TO {Name.ToUpper()} #####*****\n");
            Console.WriteLine("1. Get Customer Info");
            Console.WriteLine("2. Get Customer card Amount");
            Console.WriteLine("3. Increase Card Amount");
            Console.WriteLine("4. Withdraw money from Card");
            Console.WriteLine("5. Exit\n");

            while (true)
            {
                Console.Write("Select operation : ");
                string enter = Console.ReadLine();
                switch (enter)
                {
                    case "1":
                        GetCustomerInfo();
                        break;
                    case "2":
                        GetCustomerCardAmount();
                        break;
                    case "3":
                        IncreaseCardAmount();
                        break;
                    case "4":
                        WithDraw();
                        break;
                    case "5":
                        isEnd = true;
                        break;
                    default:
                        Console.WriteLine("Invalid operation!");
                        break;
                }

                if (isEnd)
                {
                    Console.WriteLine("Good bye!");
                    break;
                }
            }
        }

        public bool Validate(string username)
        {
            if (username == "Not Found" || String.IsNullOrWhiteSpace(username))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("User Not Found!\n");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
            return true;
        }
        public void GetCustomerInfo()
        {
            Console.Write("UserName : ");
            string username = Console.ReadLine() ?? "Not Found";   

           if(!Validate(username))
                return;

            foreach(Customer user in Customers)
            {
                if ( user.NameSurname.ToLower() == username.ToLower())
                {
                    user.PrintInfo();
                }    
            }
        }

        public void GetCustomerCardAmount()
        {
            Console.Write("UserName : ");
            string username = Console.ReadLine() ?? "Not Found";

            if (!Validate(username))
                return;

            foreach (Customer user in Customers)
            {
                if (user.NameSurname.ToLower() == username.ToLower())
                {
                   Console.WriteLine($"Amount : {user.BankCard.Cardamount}");
                }
            }
        }

        public void IncreaseCardAmount()
        {
            Console.Write("UserName : ");
            string username = Console.ReadLine() ?? "Not Found";
            Console.Write("Amount : ");
            double amount = double.Parse(Console.ReadLine());

            if (!Validate(username))
                return;

            foreach (Customer user in Customers)
            {
                if (user.NameSurname.ToLower() == username.ToLower())
                {
                    user.BankCard.IncreaseAmount(amount);
                }
            }
        }

        public void WithDraw()
        {
            Console.Write("UserName : ");
            string username = Console.ReadLine() ?? "Not Found";
            Console.Write("Password : ");
            string password = Console.ReadLine() ?? "Not Found";
            Console.Write("Amount : ");
            double amount = double.Parse(Console.ReadLine());

            if (!Validate(username))
                return;

            foreach (Customer user in Customers)
            {
                if (user.NameSurname.ToLower() == username.ToLower())
                {

                   if( user.BankCard.WithDraw(amount, password))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Successfull");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Something went wrong!");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
