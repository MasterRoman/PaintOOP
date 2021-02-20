using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP.Model.PaintingModel
{

    public struct LineConfiguration
    {
        public int width;
        public System.Drawing.Color color;
        public System.Drawing.Drawing2D.DashStyle style;
    }
    public struct FillConfiguration
    {
        public System.Drawing.Color color;
    }

    public interface IPaintingProperty
    {
        LineConfiguration penProperty { get; set; }
        FillConfiguration brushProperty { get; set; }
    }
}
