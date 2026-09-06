namespace InheritanceWorkshopBackend
{
    public class Trapeze : Triangle
    {
        //Fields
        private double _d;

        //Properties
        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }

        //Public Methods
        public override double GetArea() 
        {
            return ((B + D) * H) / 2.0;
        }
        public override double GetPerimiter() 
        {
            return A + B + C + D;
        }
        public Trapeze(string name, double a, double b, double c, double d, double h) 
        : base(name, a, b, c, h)
        {
            D = d;
        }

        //Private Methods

        private double ValidateD(double d)
        {
            if (d <= 0)
                throw new Exception("El lado D debe ser mayor que cero.");
            return d;
        }
    }
}
