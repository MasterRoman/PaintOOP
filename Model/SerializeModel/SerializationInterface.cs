﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP.Model.SerializeModel
{
    interface ISerialization
    {
        void serialize(IFigure figure);
        IFigure deserialize();

        string filePath { get; set; }

    }
}
