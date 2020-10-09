using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithCompiledMarkup
{
   public  class Calculator
    {
        int operandOne;
        int operandTwo;
        int result;

        public void Add()
        {
            int temp = operandOne + operandTwo;
        }
        public void  Sub()
        {
            int temp = operandOne - operandTwo;
        }

        public void Clear()
        {
            //Clear All 
        }
    }
}
