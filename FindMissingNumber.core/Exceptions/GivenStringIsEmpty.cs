using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingNumber.core.Exceptions
{
    public class GivenStringIsEmpty : Exception
    {
        public GivenStringIsEmpty()
            : base("Given statement is empty")
        {

        }
    }
}
