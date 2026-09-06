namespace InheritanceWorkshopBackend
{
    public abstract class GeometricFigure
    {

        //Properties
        public string Name
        {
            get;
            set;
        }

        //Constructors
        protected GeometricFigure(string name)
        {
            Name = name;
        }

        //Public Methods
        public override string ToString()
        {
            return $"{Name}\n" +
               $"  => Area.....: {GetArea(),11:N5}\n" +
               $"  => Perimeter: {GetPerimiter(),11:N5}\n";
        }

        public abstract double GetArea();

        public abstract double GetPerimiter();

    }
}