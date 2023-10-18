using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace Inlämningsupgift4_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett heltal");
            int tal = int.Parse(Console.ReadLine());
            int störst = tal;

            string svar = "";
            while (svar != "n") 
            {
                Console.WriteLine("vill du skriva ett till heltal? j/n");
                svar = Console.ReadLine();   
                if (svar == "n")
                {
                    break;
                }
                Console.WriteLine("Skriv in ett till heltal");
                int nytttal= int.Parse(Console.ReadLine());

                if(nytttal > störst)
                {
                    störst = nytttal;
                }






            }
            Console.WriteLine("Det största talet du skrev var " + störst);
           
            
        }
    }
}