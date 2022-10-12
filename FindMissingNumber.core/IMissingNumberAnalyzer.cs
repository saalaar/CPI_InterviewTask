using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingNumber.core
{
    public interface IMissingNumberAnalyzer
    {
        int[] Analyze(string inputStatement);
    }
}
