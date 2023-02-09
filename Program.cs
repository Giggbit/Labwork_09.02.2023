using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_08._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard card = new CreditCard();
            card.Enter();
            card.Print();
            
        }
    }
}
