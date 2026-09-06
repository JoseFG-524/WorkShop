namespace InheritanceWorkshopBackend
{
    public class Circle : GeometricFigure
    {
        //Fields
        private double _r;

        //Properties
        public double R
        { 
            get => _r; 
            set => _r = ValidateR(value); 
        }

        //Public Methods
        public Circle( string name, double r) : base(name)
        {
            R = r;
        }
        public override double GetArea()
        {
            return Math.PI* Math.Pow(R, 2);
        }
        public override double GetPerimiter()
        {
            return 2 * Math.PI * R;
        }

        //Private Methods
        private double ValidateR(double r)
        {
            if (r <= 0)
                throw new Exception("El radio debe ser un valor mayor que cero.");
            return r;
        }
    }
}
