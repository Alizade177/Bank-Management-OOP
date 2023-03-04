using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public class Customer
    {
        public Customer(string nameSurname, string phoneNumber, BankCard bankCard)
        {
            NameSurname = nameSurname;
            PhoneNumber = phoneNumber;
            BankCard = bankCard;
        }   

        public string NameSurname { get; set; } 
        public string PhoneNumber { get; set; }
        public BankCard BankCard { get; set; }
        public DateTime Birtday { get; set; }

         public void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n-----{NameSurname} info-----");
            Console.WriteLine($"Name Surname : {NameSurname} \nPhone Number : {PhoneNumber} \nCard Number : {BankCard.GetCardNumber()} \nBirtday : {Birtday}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
