using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulConsoleApp
{
    class oprtionMethod : oprtion
    {
       



       
        public override int sum(int x, int y)
        {
            return (x + y);

        }

        public override int sub(int x, int y)
        {
           
           return (x - y);

        }

        public override double div(double x, double y)
        {
            
           
                return (x / y);
           
        }

        public override int mult(int x, int y)
        {
          
            return (x * y);

        }
    }
}
