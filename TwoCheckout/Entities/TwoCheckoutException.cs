﻿using System;

namespace TwoCheckout
{
    public class TwoCheckoutException : ApplicationException
    {
        public String message { get; set; }

        public TwoCheckoutException(string message)
            : base(message)
		    {

		    }
    }
}

