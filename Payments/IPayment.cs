﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Selection.Payments
{
    public interface IPayment
    {
        string Pay(decimal amount);
    }
}
