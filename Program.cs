using System;
using System.Collections.Generic;

namespace LSP_Payment_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our eCommerce Validation Bankcard");
          
      
            List<PaymentInstrument> listcards = new List<PaymentInstrument>();
            listcards.Add(new DebitCard("Hannah Mayer", "05904806842", new DateTime(2021, 12, 24)));
            listcards.Add(new CreditCard("Thomas Heinrich", "125774676871", new DateTime(2022, 11, 24)));
            listcards.Add(new DebitCard("Heinz Zettl", "217897746947", DateTime.Today));
            listcards.Add(new CreditCard("Felix Zimmermann", "127655813734", new DateTime(2023, 08, 13)));
            listcards.Add(new RewardCard("Julia Maier", "4572775"));

            foreach (var e in listcards)
            {  
                Console.WriteLine(e.GetType()+"\n"+e.ToString());
                e.validate();
              
            }
        }
    }
}
