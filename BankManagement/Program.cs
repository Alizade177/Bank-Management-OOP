using BankManagement;
using System;

namespace namesapce1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer("User User1", "+994508794512", new BankCard("1234 5678 9123 4569","12345"));
            Bank bank = new Bank("MyBank");

            bank.Customers.Add(customer);
            
            bank.Start();
        }
    }
}