using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP.Model
{
    struct LineConfiguration
    {
        int width;
        System.Drawing.Color color;
        System.Drawing.Drawing2D.DashStyle style;
    }
    interface IFigure
    {
        void drawFigure(System.Windows.Forms.PaintEventArgs e);
        LineConfiguration pen { get; set; }
        bool isClosed { get; set; }
    }
}
