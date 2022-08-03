﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //base demek Resulta eşit oluyor
        public SuccessResult(string message) : base(true, message)
        {

        }
        public SuccessResult() : base(true)//mesaj vermek istemediğin zaman
        {

        }
    }
}
