using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintOOP.Model.PaintingModel;

namespace PaintOOP.Model
{
   
    public interface IFigure
    {
        void drawFigure(System.Windows.Forms.PaintEventArgs e);
        LineConfiguration pen { get; set; }
        FillConfiguration brush { get; set; }
    }

    public abstract class Figure : IFigure
    {
        public virtual void drawFigure(System.Windows.Forms.PaintEventArgs e)
        {

        }
        public LineConfiguration pen { get; set; }

        public FillConfiguration brush { get; set; }
    }

    public abstract class StaticFigure : Figure
    {
        public System.Drawing.Point topLeftCoords { get; set; }
        public System.Drawing.Point bottomRightCoords { get; set; }
    }

    public abstract class DynamicFigure : Figure
    {
        public List<System.Drawing.Point> points { get; set; }
        public virtual void addPoints(System.Drawing.Point points)
        {
            this.points.Add(points);
        }

        public abstract void closeFigure();

    }

}
