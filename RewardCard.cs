using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Payment_csharp
{
    public class RewardCard : PaymentInstrument
    {
        private string _name;
        private string _cardNumber;
        public RewardCard(string name, string cardNumber)
        {
            this._name = name;
            this._cardNumber = cardNumber;
        }

        public override void validate()
        {
            if (_name == null)
            {
                Console.WriteLine("Name is invalid \n");

                throw new ArgumentNullException();
            }

            else if (_cardNumber == null)
            {
                Console.WriteLine("Card number is invalid \n");
                throw new ArgumentNullException();
            }
          else if(_cardNumber.Length <= 5)
            {
                Console.WriteLine("OK, Your Cardnumber is correct\n");
            }
            else
            {
                Console.WriteLine("It is a fraud, Your Cardnumber doesnt match with our database\n");
            }

        }
        public override string ToString()
        {
            return String.Format("Name: {0} , CardNumber: {1} \n", this._name, this._cardNumber);

        }
    }
}
