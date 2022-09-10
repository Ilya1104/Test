using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public interface ITriangle
    {
         double SideA { get;  }
         double SideB { get; }
         double SideC { get; }
        bool IsRectangular { get; }
        bool IsRectangularTriangle();
    }
}
