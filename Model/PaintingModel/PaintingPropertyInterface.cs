using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP.Model.PaintingModel
{

    public struct LineConfiguration
    {
        int width;
        System.Drawing.Color color;
        System.Drawing.Drawing2D.DashStyle style;
    }
    public struct FillConfiguration
    {
        System.Drawing.Color color;
    }

    interface IPaintingProperty
    {
        LineConfiguration penProperty { get; set; }
        FillConfiguration brushProperty { get; set; }
    }
}
