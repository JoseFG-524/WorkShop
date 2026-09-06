namespace InheritanceWorkshopBackend
{
    internal class Parallelogram : Rectangle
    {
        //Fields
        private double _h;

        //Properties
        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        //Public Methods
        public override double GetArea() 
        {
            return B * H;
        }
        public override double GetPerimiter() 
        {
            return 2 * (A + B);
        }
        public Parallelogram(string name, double a, double b, double h) 
        : base(name, a, b)
        {
            H = h; 
        }

        //Private Methods

        private double ValidateH(double h)
        {
            if (h <= 0)
                throw new Exception("La altura H debe ser mayor que cero.");
            return h;
        }
    }
}
