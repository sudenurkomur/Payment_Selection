using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payment_Selection.Payments;
using System.Reflection;

namespace Payment_Selection.Services
{
    public class PaymentFactory
    {
        public IPayment CreateInstance(string className)
        {
            var fullName = "Payment_Selection.Payments." + className;
            var obj = Assembly.GetExecutingAssembly().CreateInstance(fullName);
            return (IPayment)obj;
        }

    }
}
