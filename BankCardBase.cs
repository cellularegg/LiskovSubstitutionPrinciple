using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Payment_csharp
{
    public abstract class  BankCardBase : PaymentInstrument
    {
       protected string _name;
        protected string _cardNumber;
        protected DateTime _expiryDate;
    
        public BankCardBase(string name, string cardNumber, DateTime expiryDate)
        {
            this._name = name;
            this._cardNumber = cardNumber;
            this._expiryDate = expiryDate;
        }
        public override string ToString()
        {
            return String.Format("Name: {0} , CardNumber: {1}, Date: {2} \n", this._name, this._cardNumber, this._expiryDate);
        }
        public override void  validate()
        {
            if (_name == null)
            {
                Console.WriteLine("Name is invalid \n");

                Console.WriteLine(new ArgumentNullException());
            }

           else if (_cardNumber == null)
            {
                Console.WriteLine("Card number is invalid \n");
                Console.WriteLine( new ArgumentNullException() + "\n");
            }
            else if (_expiryDate.Date == DateTime.Today || _expiryDate.Date <= DateTime.Today)
            {
                Console.WriteLine("Card is expiried");
            }
        }
    }

}
