using System;

namespace PercentTask
{
    class Program
    {
        static void Main(string[] args)
        {
            long budget = 20000000000;

            double mudNaz = budget * 0.2;

            double texNaz = budget * 0.1;

            double currentbudget = budget - (mudNaz + texNaz);

            Console.WriteLine("Budce : "+budget);

            Console.WriteLine("Mudafie Nazirliyine : "+mudNaz);

            Console.WriteLine("Yüksek Texnologiyalar Nazirliyine : "+texNaz);

            Console.WriteLine("Yerde qalan budce : "+currentbudget);

        }
    }
}
