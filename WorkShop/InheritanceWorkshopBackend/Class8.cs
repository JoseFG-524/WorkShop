namespace InheritanceWorkshopBackend
{
    internal class Triangle : Rectangle
    {
        //Fields
        private double _c;
        private double _h;

        //Properties
        public double C
        {
            get => _c;
            set => _c = ValidateC(value);
        }
        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        //Public Methods
        public override double GetArea() 
        {
            return (B * H) / 2.0;
        }
        public override double GetPerimiter()
        {
            return A + B + C;
        }
        public Triangle(string name, double a, double b, double c, double h) 
        : base(name, a, b)
        {
            C = c;
            H = h;
        }

        //Private Methods
        private double ValidateC(double c)
        {
            if (c <= 0)
                throw new Exception("El lado C debe ser mayor que cero.");
            return c;
        }
        private double ValidateH(double h)
        {
            if (h <= 0)
                throw new Exception("La altura H debe ser mayor que cero.");
            return h;
        }
    }
}
