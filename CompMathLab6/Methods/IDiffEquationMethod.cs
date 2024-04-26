using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMathLab6
{
    public interface IDiffEquationMethod
    {
        double Step {  get;}
        double UseMethod(double x, double y);
    }
}
