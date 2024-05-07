namespace CompMathLab6
{
    public class EulerDiffEquation : IDiffEquationMethod
    {
        private FuncXY _funcXY;
        private double _step;
        public double Step
        {
            get { return _step; }
        }
        public EulerDiffEquation(double step, FuncXY funcXY) 
        {
            _step = step;
            _funcXY = funcXY;
        }
        public double UseMethod(double x,double y)
        {
            return y + _step * _funcXY.GetResult(x,y); 
        }
    }
}
