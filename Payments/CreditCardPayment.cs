using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Selection.Payments
{
    public class CreditCardPayment : IPayment
    {
        public string Pay(decimal amount)
        {
            return $"{amount} TL kredi kartı ile ödendi.";
        }
    }
}
