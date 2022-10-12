using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingNumber.core.Exceptions
{
    public class GivenNumberIsZeroOrNegativeException : Exception
    {
        public GivenNumberIsZeroOrNegativeException()
            : base("Give number is a negative number or zero, it must be positive number")
        {

        }
    }
}
