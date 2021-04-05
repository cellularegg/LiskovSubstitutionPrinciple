using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Payment_csharp
{
    public class CreditCard : BankCardBase
    {
        public CreditCard(string name, string cardNumber, DateTime expiryDate) : base(name, cardNumber, expiryDate)
        {
        }
        public override void validate()
        {
            base.validate();

           if (_cardNumber.StartsWith("12"))
            {
                Console.WriteLine("OK, Your Cardnumber is correct\n");
            }
            else
            {
                Console.WriteLine("It is a fraud, Your Cardnumber doesnt match with our database\n");
            }
        }

    }
}
