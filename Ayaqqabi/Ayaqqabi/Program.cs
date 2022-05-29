using System;

namespace Ayaqqabi
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOR ADIDAS
            string companyname = "Adidas";
            int shoenumber = 4;
            int shoeprice = 200;
            char dollar = '$';

            int totalprice = shoenumber * shoeprice;

            Console.WriteLine("Company name : "+companyname);

            Console.WriteLine("Number of shoe : "+shoenumber);
           
            Console.WriteLine("Price of shoe : " + shoeprice);

            Console.WriteLine("Total price : "+totalprice +dollar);
            Console.WriteLine("");
             
            // FOR GUCCI
            string companyname2 = "Gucci";
            int shoenumber2 = 2;
            int shoeprice2 = 1000;
           

            int totalprice2 = shoenumber * shoeprice;

            Console.WriteLine("Company name : " + companyname2);

            Console.WriteLine("Number of shoe : " + shoenumber2);

            Console.WriteLine("Price of shoe : " + shoeprice2);

            Console.WriteLine("Total price : " + totalprice2 + dollar);
            Console.WriteLine("");

            // FOR NIKE
            string companyname3 = "Nike";
            int shoenumber3 = 1;
            int shoeprice3 = 150;
            

            int totalprice3 = shoenumber * shoeprice;

            Console.WriteLine("Company name : " + companyname3);
            
            Console.WriteLine("Number of shoe : " + shoenumber3);

            Console.WriteLine("Price of shoe : " + shoeprice3);

            Console.WriteLine("Total price : " + totalprice3 + dollar);
        }
    }
}
