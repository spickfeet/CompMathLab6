using CompMathLab6;
using System.Drawing.Printing;

public class FifthAdams : IDiffEquationMethod
{
    private double[] k = new double[6];
    private double[] temp = new double[5];
    private double[] temp2 = new double[5];
    private int _elementIndex = -1;
    private double _step;
    private FuncXY _funcXY;
    public FifthAdams(double startStep, FuncXY funcXY)
    {
        _funcXY = funcXY;
        _step = startStep;
    }

    public double Step => _step;

    //Рунге–Кутты–Мерсона 5 - го порядка
    public double Set(double x, double y)
    {
        k[0] = _step * _funcXY.GetResult(x, y);
        k[1] = _step * _funcXY.GetResult(x + 1 / 4d * _step, y + 1 / 4d * k[0] * _step);
        k[2] = _step * _funcXY.GetResult(x + 1 / 4d * _step, y + 1 / 8d * k[0] * _step + 1 / 8d * k[1] * _step);
        k[3] = _step * _funcXY.GetResult(x + 1 / 2d * _step, y - 1 / 2d * k[1] + k[2] * _step);
        k[4] = _step * _funcXY.GetResult(x + 3 / 4d * _step, y + 3 / 16d * k[0] * _step + 9 / 16d * k[3] * _step);
        k[5] = _step * _funcXY.GetResult(x + _step, y - 3 / 7d * k[0] * _step + 2 / 7d * k[1] * _step + 12 / 7d * k[2] * _step - 12 / 7d * k[3] * _step + 8 / 7d * k[4] * _step);
        temp[_elementIndex] = y + _step / 90d * (7 * k[0] + 32 * k[2] + 12 * k[3] + 32 * k[4] + 7 * k[5]);
        temp2[_elementIndex] = x;
        return temp[_elementIndex];       
    }

    public double UseMethod(double x, double y)
    {
        // Нахождение первых 5 точек методом 5-го порядка
        if (_elementIndex < 4)
        {
            _elementIndex++;
            // Первая точка уже известна заполняем её
            if(_elementIndex == 0)
            {
                temp[_elementIndex] = y;
                temp2[_elementIndex] = x - _step;
                _elementIndex++;
            }
            return Set(x, y);
        }
        // Метод Адамса 5-го порядка
        y = y + _step / 720d * (1901d * _funcXY.GetResult(temp2[4], temp[4])
            - 2774d * _funcXY.GetResult(temp2[3], temp[3])
            + 2616d * _funcXY.GetResult(temp2[2], temp[2])
            - 1274d * _funcXY.GetResult(temp2[1], temp[1])
            + 251d * _funcXY.GetResult(temp2[0], temp[0]));
        temp[0] = temp[1];
        temp[1] = temp[2];
        temp[2] = temp[3];
        temp[3] = temp[4];
        temp[4] = y;
        temp2[0] = temp2[1];
        temp2[1] = temp2[2];
        temp2[2] = temp2[3];
        temp2[3] = temp2[4];
        temp2[4] = x;
        return y;
    }
}
