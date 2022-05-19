using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innoflow_Movies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] users = File.ReadAllLines(@"C:\Users\toblar\Desktop\MovieData\MovieData\Users.txt");
            string[] products = File.ReadAllLines(@"C:\Users\toblar\Desktop\MovieData\MovieData\Products.txt");
            string[] currentUser = File.ReadAllLines(@"C:\Users\toblar\Desktop\MovieData\MovieData\CurrentUserSession.txt");

            //Populære film
            Console.WriteLine(users[0]);


            /*foreach (var item in products)
            {
                console.writeline("bedst ratede film: " + rating);
                console.writeline("mest købte: " + købte);
            }*/

            //Anbefalede film



            Console.ReadKey();
        }
    }
}
