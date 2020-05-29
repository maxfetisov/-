namespace Задание_1._1
{
    class Hyperbola : Function
    {
        public Hyperbola(double a, double b) : base(a, b) { }
        public override double Calculate(double x) => a / x + b;
    }
}
