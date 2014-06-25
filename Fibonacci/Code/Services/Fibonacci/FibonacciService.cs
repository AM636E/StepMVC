using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fibonacci.Code.Services.Fibonacci
{
    public class FibonacciService : IFibonacciService
    {
        public List<long> GetNumbers(int count)
        {
            int first = 1;
            int second = 1;
            int accum = 0;
            List<long> numbers = new List<long>() { first, second };

            for (int i = 0; i < count; i++)
            {
                accum = first + second;
                numbers.Add(accum);
                second = first;
                first = accum;
            }

            return numbers;
        }
    }
}