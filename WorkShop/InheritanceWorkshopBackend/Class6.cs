namespace InheritanceWorkshopBackend
{
    internal class Rectangle : Square
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
            return A * B;
        }
        public override double GetPerimiter()
        {
            return 2 * (A + B);
        }
        public Rectangle(string name, double a, double b) : base(name, a)
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
