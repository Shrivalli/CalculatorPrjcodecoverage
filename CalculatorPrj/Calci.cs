using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrj
{
    public class Calci : ICalculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }

        public bool checkage(int age)
        {
            if (age > 18)
                return true;
            else
                return false;
        }

        public int validdata()
        {
            bool res=checkage(19);
            if (res == true)
                return 10;
            else
                return 20;
        }
    }
}
