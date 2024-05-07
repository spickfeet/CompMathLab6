using CompMathLab6;

public class FifthAdams : IDiffEquationMethod
{
    private double[] k = new double[6];
    private double[] tempY = new double[5];
    private double[] tempX = new double[5];
    private int _elementIndex = -1;
    private double _step;
    private FuncXY _funcXY;
    public FifthAdams(double startStep, FuncXY funcXY)
    {
        _funcXY = funcXY;
        _step = startStep;
    }

    public double Step => _step;

    //Рунге–Кутты 5 - го порядка
    public double Set(double x, double y)
    {
        k[0] = _funcXY.GetResult(x, y);
        k[1] = _funcXY.GetResult(x + 1 / 4d * _step, y + 1 / 4d * k[0] * _step);
        k[2] = _funcXY.GetResult(x + 1 / 4d * _step, y + 1 / 8d * k[0] * _step + 1 / 8d * k[1] * _step);
        k[3] = _funcXY.GetResult(x + 1 / 2d * _step, y - 1 / 2d * k[1] + k[2] * _step);
        k[4] = _funcXY.GetResult(x + 3 / 4d * _step, y + 3 / 16d * k[0] * _step + 9 / 16d * k[3] * _step);
        k[5] = _funcXY.GetResult(x + _step, y - 3 / 7d * k[0] * _step + 2 / 7d * k[1] * _step + 12 / 7d * k[2] * _step - 12 / 7d * k[3] * _step + 8 / 7d * k[4] * _step);
        tempY[_elementIndex] = y + _step / 90d * (7 * k[0] + 32 * k[2] + 12 * k[3] + 32 * k[4] + 7 * k[5]);
        tempX[_elementIndex] = x;
        return tempY[_elementIndex];       
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
                tempY[_elementIndex] = y;
                tempX[_elementIndex] = x;
                _elementIndex++;
            }
            return Set(x, y);
        }
        // Метод Адамса 5-го порядка
        y = y + _step / 720d * (1901d * _funcXY.GetResult(tempX[4], tempY[4])
            - 2774d * _funcXY.GetResult(tempX[3], tempY[3])
            + 2616d * _funcXY.GetResult(tempX[2], tempY[2])
            - 1274d * _funcXY.GetResult(tempX[1], tempY[1])
            + 251d * _funcXY.GetResult(tempX[0], tempY[0]));
        tempY[0] = tempY[1];
        tempY[1] = tempY[2];
        tempY[2] = tempY[3];
        tempY[3] = tempY[4];
        tempY[4] = y;
        tempX[0] = tempX[1];
        tempX[1] = tempX[2];
        tempX[2] = tempX[3];
        tempX[3] = tempX[4];
        tempX[4] = x;
        return y;
    }
}
