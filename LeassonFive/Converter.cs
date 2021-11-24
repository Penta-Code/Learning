using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeassonFive
{
    internal class Converter
    {
        double usd, eur, rub;

        public double Usd { get { return usd; } }
        public double Eur { get { return eur; } }
        public double Rub { get { return rub; } }
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void BuyUSD(int summ)
        {
            double result = summ / usd;
            Console.WriteLine($"\nYou have bought {result} dollars");
        }

        public void SellUSD(int summ)
        {
            double result = usd * summ;
            Console.WriteLine($"You have sold {summ} dollars and got {result} soms");
        }

        public void BuyEUR(int summ)
        {
            double result = summ / eur;
            Console.WriteLine($"\nYou have bought {result} euros");
        }

        public void SellEUR(int summ)
        {
            double result = eur * summ;
            Console.WriteLine($"You have sold {summ} euros and got {result} soms");
        }

        public void BuyRUB(int summ)
        {
            double result = summ / rub;
            Console.WriteLine($"\nYou have bought {result} rubles");
        }

        public void SellRUB(int summ)
        {
            double result = rub * summ;
            Console.WriteLine($"You have sold {summ} rubles and got {result} soms");
        }

        public override string ToString()
        {
            return $"Current curencies values:\nUSD = {usd}\nEUR = {eur}\nRUB = {rub}";
        }
    }
}