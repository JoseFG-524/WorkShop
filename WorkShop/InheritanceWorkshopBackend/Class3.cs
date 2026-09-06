namespace InheritanceWorkshopBackend
{
    public class Square : GeometricFigure
    {
        //Fields
        private double _a;

        //Properties
        public double A
        {
            get => _a;
            set => _a = ValidateA(value);
        }

        //Public Methods
        public override double GetArea()
        {
            return Math.Pow(A, 2);
        }
        public override double GetPerimiter() 
        {
            return 4 * A;
        }
        public Square(string name, double a) : base(name)
        {
            A = a;
        }

        //Private Methods

        private double ValidateA(double a)
        {
            if (a <= 0)
                throw new Exception("El lado debe ser mayor que cero.");
            return a;
        }
    }
}
