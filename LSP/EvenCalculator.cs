using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class EvenCalculator : Calculator
    {
        public EvenCalculator(int[] numbers):base(numbers)
        {
            
        }
        public override int Calculate()
        {
          return _numbers.Where(x => x % 2 == 0).Sum();
        }
    }
}
