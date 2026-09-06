namespace InheritanceWorkshopBackend
{
    internal class Kite : Rhombus
    {
        //Fields
        private double _b;

        //Properties
        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        //Public Methods
        public override double GetArea() 
        {
            return (D1 * D2) / 2.0;
        }
        public override double GetPerimiter() 
        {
            return 2 * (A + B);
        }
        public Kite(string name, double a, double b, double d1, double d2)
        : base(name, a, d1, d2)
        {
            B = b;
        }

        //Private Methods

        private double ValidateB(double b)
        {
            if (b <= 0)
                throw new Exception("El lado B debe ser mayor que cero.");
            return b;
        }
    }
}
