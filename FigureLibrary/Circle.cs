using System;

namespace FigureLibrary
{
    public class Circle:IFigure
    {
        private double Radius { get; set; }
        public Circle(double radius)
        {
            if(radius <= 0)
            {
                throw new ArgumentException("Wrong Radius!!!!!!", nameof(radius));
            }
            else
            {
                this.Radius = radius;
            }
            
        }
        public double FigureSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
