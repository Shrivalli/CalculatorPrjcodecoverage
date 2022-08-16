using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrj
{
   public interface ICalculator
    {
        int add(int a, int b);
        int sub(int a, int b);

        string message(string name)
        {
            return "Hello " + name;
        }

        bool checkage(int age);

        int validdata();
        

        

    }
}
