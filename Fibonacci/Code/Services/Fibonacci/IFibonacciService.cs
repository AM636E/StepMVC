using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Code.Services.Fibonacci
{
    interface IFibonacciService
    {
        List<long> GetNumbers(int count);
    }
}
