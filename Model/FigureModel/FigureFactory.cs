using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintOOP.Model.PaintingModel;

namespace PaintOOP.Model
{
    public interface IFactory<TFigure> where TFigure : IFigure
    {
        TFigure create(System.Drawing.Point points, IPaintingProperty paintingProperty);

    }

}
