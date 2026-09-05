namespace InheritanceWorkshopBackend
{
    public abstract class GeometricFigure
    {

        //Properties
        public int Name
        {
            get;
            set;
        }

        //Constructors
        protected GeometricFigure()
        {

        }

        //Public Methods
        public override string ToString()
        {
            return $"{Name}\n" +
               $"  => Area.....: {GetArea(),11:N5}\n" +
               $"  => Perimeter: {GetPerimiter(),11:N5}\n";
        }

        public int GetArea() 
        { 
        
        }

        public abstract int GetPerimeter() 
        { 
        
        }
    }
}