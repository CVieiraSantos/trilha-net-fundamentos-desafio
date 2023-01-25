using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Exceptions
{
    public class WrongFormat : Exception
    {
        public WrongFormat(string message) : base(message)
        {
            throw new FormatException(message);
        }
    }
}