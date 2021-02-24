using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP.Model.SerializeModel
{
    interface ISerialization<TFigure> where TFigure : IFigure
    {
        void serialize(TFigure figure);
        TFigure deserialize();

        string filePath { get; set; }

    }
}
