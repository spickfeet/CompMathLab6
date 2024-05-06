using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMathLab6.Methods
{
    public class RungeKuttyMersonDiffEquation : IDiffEquationMethod
    {
        private double _accuracy;
        private double _step;
        private FuncXY _funcXY;
        private double[] k = new double[5];
        public double Step
        {
            get { return _step; }
        }
        public RungeKuttyMersonDiffEquation(double startStep,FuncXY funcXY,double accuracy)
        {
            _funcXY = funcXY;
            _step = startStep;
            _accuracy = accuracy;
        }
        public double UseMethod(double x, double y)
        {
            double deltaN;
            do
            {
                k[0] = _step * _funcXY.GetResult(x, y);
                k[1] = _step * _funcXY.GetResult(x + 1 / 3d * _step, y + 1 / 3d * k[0]);
                k[2] = _step * _funcXY.GetResult(x + 1 / 3d * _step, y + 1 / 6d * k[0] + 1 / 6d * k[1]);
                k[3] = _step * _funcXY.GetResult(x + 1 / 2d * _step, y + 1 / 8d * k[0] + 3 / 8d * k[2]);
                k[4] = _step * _funcXY.GetResult(x + _step, y + 1 / 2d * k[0] - 3 / 2d * k[2] + 2 * k[3]);
                deltaN = 1 / 30d * (2 * k[0] - 9 * k[2] + 8 * k[3] - k[4]);
                //if(Math.Abs(deltaN) < _accuracy)
                //{
                //    break;
                //}
                _step /= 2;

            }while(Math.Abs(deltaN) > _accuracy);
            if (Math.Abs(deltaN) <= _accuracy / 32)
            {
                _step *= 2;
            }
            return y + 1 / 6d * k[0] + 2 / 3d * k[3] + 1 / 6d * k[4];
        }
    }
}
