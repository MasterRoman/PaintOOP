using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintOOP.Model.PaintingModel;

namespace PaintOOP.Model
{
    public interface IFactory
    {
        IFigure create(System.Drawing.Point points, IPaintingProperty paintingProperty);

    }

    public abstract class FigureFactory : IFactory
    {
        public abstract IFigure create(System.Drawing.Point points, IPaintingProperty paintingProperty);
    }
}
