using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Selection.Payments
{
   
        public class CashPayment : IPayment
        {
            public string Pay(decimal amount)
            {
                return $"{amount} TL nakit olarak ödendi.";
            }
        }
    }
