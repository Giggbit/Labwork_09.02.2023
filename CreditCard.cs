using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_08._02._2023
{
    internal class CreditCard
    {
        private string name;
        private string surname;
        private string num_card;
        private string date;
        private int cvv;

        public CreditCard() { }
        public CreditCard(string n, string s, string nc, string d, int c) {
            name = n;
            surname = s;
            num_card = nc;
            date = d;
            cvv = c;
        }
            
        public void Enter() {
            int count = 0;
            while (count != 5) {
                try
                {
                    Console.Write("Enter your name: ");
                    name = Console.ReadLine();
                    if (name.Length <= 1)
                    {
                        throw new Exception("Minimal amount words = 2!");
                    }
                    count++;
                    Console.Write("Enter your surname: ");
                    surname = Console.ReadLine();
                    if (surname.Length <= 2)
                    {
                        throw new Exception("Minimal amount words = 3!");
                    }
                    count++;
                    Console.Write("Enter your card number: ");
                    num_card = Console.ReadLine();
                    if (num_card.Length != 16)
                    {
                        throw new Exception("card number must be sixteen-digit!");
                    }
                    count++;
                    Console.Write("Enter card expiration date: ");
                    date = Console.ReadLine();
                    if (date.Length != 10)
                    {
                        throw new Exception("Card expiration date must be ten-digit!");
                    }
                    count++;
                    Console.Write("Enter your cvv code: ");
                    string c = Console.ReadLine();
                    if (c.Length != 3)
                    {
                        throw new Exception("cvv code must be three-digit!");
                    }
                    count++;
                    cvv = Convert.ToInt32(c);
                    Console.WriteLine($"Count = {count}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    count = 0;
                }
            }
            
        }
        public void Print() {
            Console.WriteLine($"\nName: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Card number: {num_card}");
            Console.WriteLine($"Expiration date: {date}");
            Console.WriteLine($"cvv: {cvv}");
        }


    }
}
