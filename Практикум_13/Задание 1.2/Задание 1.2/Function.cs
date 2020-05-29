namespace Задание_1._2
{
    abstract class Function
    {
        protected double a, b;
        public Function(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public abstract double Calculate(double x);
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
    }
}
