namespace CompMathLab6
{
    public interface IDiffEquationMethod
    {
        double Step {  get;}
        double UseMethod(double x, double y);
    }
}
