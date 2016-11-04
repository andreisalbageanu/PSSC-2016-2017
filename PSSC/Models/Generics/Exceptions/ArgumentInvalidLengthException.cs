using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Generics.Exceptions
{
    public class ArgumentInvalidLengthException : ArgumentException
    {
        public ArgumentInvalidLengthException(string message)
            : base(message)
        {

        }
    }
}

