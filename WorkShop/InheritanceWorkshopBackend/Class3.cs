namespace InheritanceWorkshopBackend
{
    internal class Square : GeometricFigure
    {
        //Fields
        private int _a;

        //Properties
        public int A
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
        public int Square(string name, double a) : base(name)
        {
            A = a;
        }

        //Private Methods

        private int ValidateA(double a)
        {
            if (a <= 0)
                throw new Exception("El lado debe ser mayor que cero.");
            return a;
        }
    }
}
