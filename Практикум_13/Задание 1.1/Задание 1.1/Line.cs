namespace Задание_1._1
{
    class Line : Function
    {
        public Line(double a, double b) : base(a, b) { }
        public override double Calculate(double x) => a * x + b;
    }
}
