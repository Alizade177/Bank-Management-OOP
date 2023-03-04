using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public class BankCard
    {
        public BankCard(string cardnumber,string cardPassword)
        {
            this.CardNumber = cardnumber;
            this.CardPassword = cardPassword;   
        }
        private string CardNumber { get; }

        private double cardAmount;

        private string CardPassword;
        public double Cardamount
        {
            get { return cardAmount; }

        }

        public string GetCardNumber()
        {
            return this.CardNumber;
        }

        public bool WithDraw(double amount,string password)
        {
            if (cardAmount < amount || amount < 0 || password != this.CardPassword)  
                return false;
            else
            {
                cardAmount -= amount;
                return true;
            }
        }

        public void IncreaseAmount(double amount)
        {
            cardAmount += amount;
        }
    }
}
