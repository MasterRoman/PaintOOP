using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintOOP.Model.PaintingModel;

namespace PaintOOP.Model.FigureModel.ParticularFigure
{
    public class Rectangle : ClosedFigure
    {

        public Rectangle(System.Drawing.Point points,IPaintingProperty paintingProperty)
        {
            this.isClosed = true;
            this.pen = paintingProperty.penProperty;
            this.brush = paintingProperty.brushProperty;
            
            this.topLeftCoords = points;
            this.bottomRightCoords = points;

        }
        public override void drawFigure(PaintEventArgs e)
        {
            base.drawFigure(e);
           
            System.Drawing.Pen pen = new System.Drawing.Pen(this.pen.color);
            pen.Width = this.pen.width;
            pen.DashStyle = this.pen.style;

            System.Drawing.Brush brush = new System.Drawing.SolidBrush(this.brush.color);


            int width = Math.Abs(this.topLeftCoords.X - this.bottomRightCoords.X);
            int height = Math.Abs(this.topLeftCoords.Y - this.bottomRightCoords.Y);

            e.Graphics.FillRectangle(brush,
                                    this.topLeftCoords.X,
                                    this.topLeftCoords.Y,
                                    width,
                                    height);

            e.Graphics.DrawRectangle(pen,
                                    this.topLeftCoords.X,
                                    this.topLeftCoords.Y,
                                    width,
                                    height);

        }
    }


    public class RectangleFactory : FigureFactory
    {
        public override IFigure create(System.Drawing.Point points, IPaintingProperty paintingProperty)
        {
            return new Rectangle(points,paintingProperty);
        }
    }
}
