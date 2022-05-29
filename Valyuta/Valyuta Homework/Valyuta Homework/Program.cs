using System;

namespace Valyuta_Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            int amount = 10000;

            double usd = amount / 1.7;

            double euro = amount / 1.8282;

            double ruble = amount * 38.68;

            Console.WriteLine($"Current Amount : {amount} AZN");

            Console.WriteLine($"US Dollar : {usd} USD");

            Console.WriteLine($"European Union : {euro} Euro");

            Console.WriteLine($"Russian Ruble : {ruble} Ruble");
            

        }
    }
}
