using System;

namespace month
{
    class Program
    {
        static void Main(string[] args)
        {
            string ay = "aslan";
            if (ay == "Yanvar" || ay == "Fevral" || ay == "Deakabr")
            {
                Console.WriteLine("winter");
            }
            else if (ay == "Iyun" || ay == "Iyul" || ay == "Avqust")
            {
                Console.WriteLine("summer");
            }
            else if (ay == "Mart" || ay == "aprel" || ay == "May")
            {
                Console.WriteLine("spring");
            }
            else if (ay == "sentyabr" || ay == "oktyabr" || ay == "Noyabr")
            {
                Console.WriteLine("autumn");
            }
            else
                Console.WriteLine("XAIS EDIREM AYLARIN ADINI OYREN");

        }
        


    }
}
