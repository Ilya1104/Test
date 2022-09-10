using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Triangle:IFigure, ITriangle
    {
         public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0) throw new ArgumentException("Wrong Side!!!!!!", nameof(sideA));
            if (sideB <= 0) throw new ArgumentException("Wrong Side!!!!!!", nameof(sideB));
            if (sideC <= 0) throw new ArgumentException("Wrong Side!!!!!!", nameof(sideC));
            var maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
            var perimetr = sideA + sideB + sideC;
            if (maxSide > perimetr - maxSide)
            {
                throw new ArgumentException("Wrong Max Side!!!!!!");
            }
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
            _isRectangular = new Lazy<bool>(IsRectangularTriangle);
        }
        private readonly Lazy<bool> _isRectangular;
        public bool IsRectangular => _isRectangular.Value;
        public bool IsRectangularTriangle()
        {            
            double maxSide = Math.Max(SideA, Math.Max(SideB, SideC));
            double sqrPerimetr = Math.Pow(SideA, 2) + Math.Pow(SideB, 2) + Math.Pow(SideC, 2);
            if (Math.Pow(maxSide, 2) == (sqrPerimetr - Math.Pow(maxSide, 2))) return true;
            else return false;
        }
        public double FigureSquare()
        {
            double halfPerimetr = (SideA + SideB + SideC) / 2d;
            return Math.Sqrt(halfPerimetr*(halfPerimetr - SideA)*(halfPerimetr-SideB)*(halfPerimetr-SideC));
        }
    }/*На мой взгляд, вычисление площади фигуры без знания типа фигуры затрудняет вычисления и повышает "сложность" кода.
       Тип фигуры играет важную роль, т к в зависимости от типа фигуры по разному вычисляется площадь этой фигуры, по разным формулам. 
       Чтобы упростить вычисления и код, желательно знать тип фигуры 
      
      */
}
