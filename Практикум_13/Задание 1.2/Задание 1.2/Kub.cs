namespace Задание_1._2
{
    class Kub : Function
    {
        private double c;
        public Kub(double a, double b, double c) : base(a, b)
        {
            this.c = c;
        }
        public override double Calculate(double x) => a * x * x + b * x + c;
        public double C { get => c; set => c = value; }
    }
}
