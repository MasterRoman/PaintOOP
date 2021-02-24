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
    public class Polygon : DynamicFigure
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


        public override void drawFigure(PaintEventArgs e)
        {

            System.Drawing.Pen pen = new System.Drawing.Pen(this.pen.color);
            pen.Width = this.pen.width;
            pen.DashStyle = this.pen.style;

            System.Drawing.Brush brush = new System.Drawing.SolidBrush(this.brush.color);
            e.Graphics.FillPolygon(brush, this.points.ToArray());
            e.Graphics.DrawPolygon(pen, this.points.ToArray());

        }



    }

    public class PolygonFactory : IFactory<IFigure>
    {
        public IFigure create(System.Drawing.Point points, IPaintingProperty paintingProperty)
        {
            return new Polygon(points, paintingProperty);
        }
    }
}
