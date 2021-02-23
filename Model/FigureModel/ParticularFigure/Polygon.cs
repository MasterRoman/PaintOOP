using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintOOP.Model.PaintingModel;

namespace PaintOOP.Model.FigureModel.ParticularFigure
{
    public class Polygon : OpenClosedFigure
    {
        public Polygon(System.Drawing.Point points, IPaintingProperty paintingProperty)
        {

            this.pen = paintingProperty.penProperty;
            this.brush = paintingProperty.brushProperty;

            this.points = new List<System.Drawing.Point>();
            this.points.Add(points);

        }

        public override void closeFigure()
        {
            System.Drawing.Point endPoints = new System.Drawing.Point(this.points[0].X, this.points[0].Y);
            this.points.Add(endPoints);
        }

        public override void addPoints(Point points)
        {
            this.points.Add(points);
        }

        public override void drawFigure(PaintEventArgs e)
        {
            base.drawFigure(e);

            System.Drawing.Pen pen = new System.Drawing.Pen(this.pen.color);
            pen.Width = this.pen.width;
            pen.DashStyle = this.pen.style;

          
            int count = this.points.Count;
            if ((count < 3) || (this.points[0] != this.points.Last()))
            {
                for (int i = 0; i < count - 1; i++)
                    e.Graphics.DrawLine(pen, this.points[i], this.points[i + 1]);

            }
            else
            {
                System.Drawing.Brush brush = new System.Drawing.SolidBrush(this.brush.color);
                e.Graphics.FillPolygon(brush,this.points.ToArray());
                e.Graphics.DrawPolygon(pen, this.points.ToArray());
            }
        }
    }

    public class PolygonFactory : FigureFactory
    {
        public override IFigure create(System.Drawing.Point points, IPaintingProperty paintingProperty)
        {
            return new Polygon(points, paintingProperty);
        }
    }
}
