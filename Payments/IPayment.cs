﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Selection.Payments
{
    internal interface IPayment
    {
        string Pay(int amount);
    }
}
