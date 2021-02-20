using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintOOP.Model.PaintingModel;

namespace PaintOOP.Model
{
    public abstract class FigureFactory
    {
        public abstract IFigure create(System.Drawing.Point points, IPaintingProperty paintingProperty);
    }
}
