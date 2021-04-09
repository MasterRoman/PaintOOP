using System.Windows.Forms;

using PaintOOP.Model;
using PaintOOP.Model.PaintingModel;
using System.Collections.Generic;
using System.Drawing;

namespace Trapezium
{
    public class Trapezium : DynamicFigure
    {
        public Trapezium()
        {

        }
        public Trapezium(System.Drawing.Point points, IPaintingProperty paintingProperty)
        {

            this.pen = paintingProperty.penProperty;
            this.brush = paintingProperty.brushProperty;
            this.points = new List<System.Drawing.Point>();
            this.points.Add(points);

        }

        public override void drawFigure(PaintEventArgs e)
        {

            System.Drawing.Pen pen = new System.Drawing.Pen(this.pen.color);
            pen.Width = this.pen.width;
            pen.DashStyle = this.pen.style;


            System.Drawing.Brush brush = new System.Drawing.SolidBrush(this.brush.color);


            int count = this.points.Count;
            if (count == 2)
            {
                e.Graphics.DrawLine(pen, this.points[0], this.points[1]);
            }
            else if (count == 3)
            {

                for (int i = 0; i < count - 1; i++)
                    e.Graphics.DrawLine(pen, this.points[i], this.points[i + 1]);
            }
            else
            {
                for (int i = 0; i < count - 1; i++)
                    e.Graphics.DrawLine(pen, this.points[i], this.points[i + 1]);
                e.Graphics.DrawLine(pen, this.points[count - 1], this.points[0]);
                e.Graphics.FillPolygon(brush, this.points.ToArray());
            }
        }

        public override void addPoints(Point points)
        {
            if (this.points.Count >= 4)
            {
                return;
            }
            else if (this.points.Count == 3)
            {
                var p4 = new Point(points.X, this.points[0].Y);
                this.points.Add(p4);
            }
            else if (this.points.Count == 2)
            {
                var p3 = new Point(points.X, this.points[1].Y);
                this.points.Add(p3);
            }
            else
            {
                this.points.Add(points);
            }
        }

        public override void changeLastPoints(Point points)
        {

            if (this.points.Count <= 2)
            {
                this.points[this.points.Count - 1] = points;
            }
            else if (this.points.Count == 3)
            {
                if (this.points[0].X < this.points[1].X && points.X >= this.points[1].X)
                    this.points[this.points.Count - 1] = new Point(points.X, this.points[1].Y);
                else
                    if (this.points[0].X > this.points[1].X && points.X <= this.points[1].X)
                    this.points[this.points.Count - 1] = new Point(points.X, this.points[1].Y);

            }
            else if (this.points.Count == 4)
            {
                if (this.points[2].X > this.points[1].X && points.X >= this.points[2].X)
                    this.points[this.points.Count - 1] = new Point(points.X, this.points[0].Y);
                else
                     if (this.points[2].X < this.points[1].X && points.X <= this.points[2].X)
                    this.points[this.points.Count - 1] = new Point(points.X, this.points[0].Y);
            }
        }


        public override void closeFigure()
        {

        }

    }


    public class TrapeziumFactory : IFactory<IFigure>
    {
        public IFigure create(System.Drawing.Point points, IPaintingProperty paintingProperty)
        {
            return new Trapezium(points, paintingProperty);
        }
    }
}
