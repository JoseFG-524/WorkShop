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
            return $"{Name,-15} => Area.....: {GetArea(),12:N5}    Perimeter: {GetPerimiter(),11:N5}";
        }

        public abstract double GetArea();

        public abstract double GetPerimiter();

    }
}