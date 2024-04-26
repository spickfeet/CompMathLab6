using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMathLab6
{
    public class UpgradeEulerDiffEquation : IDiffEquationMethod
    {
        private FuncXY _funcXY;
        private double _step;
        public double Step
        {
            get { return _step; }
        }
        public UpgradeEulerDiffEquation(double step, FuncXY funcXY)
        {
            _step = step;
            _funcXY = funcXY;
        }
        public double UseMethod(double x, double y)
        {
            return y + _step * _funcXY.GetResult(x + _step / 2, y + _step / 2 * _funcXY.GetResult(x, y));
        }
    }
}
