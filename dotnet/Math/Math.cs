namespace Math;
public static class Math
{
    public static double Divide(double a, double b)
    {
        if (b == 0d)
        {
            throw new InvalidOperationException("Cannot divide by zero");
        }

        return a * 1d / b;
    }
}
