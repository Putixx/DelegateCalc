namespace DelegateCalc
{
    public static class Calculation
    {
        public static double Addition(double x, double y) => x + y;
        public static double Subtraction(double x, double y) => x - y;
        public static double Multiplication(double x, double y) => x * y;
        public static double Power(double x, double y) => Math.Pow(x, y);
        public static double Root(double x, double y = 2) => Math.Pow(x, 1.0 / y);
        public static double Division(double x, double y)
        {
            if (y != 0) return x / y;
            else throw new ArgumentException("Can't divide by 0");
        }
    }
}
