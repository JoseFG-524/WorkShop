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
            return base.ToString();
        }

        public int GetArea() 
        { 
        
        }

        public abstract int GetPerimeter() 
        { 
        
        }
    }
}