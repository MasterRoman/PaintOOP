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

            e.Graphics.DrawRectangle(pen,
                                    this.topLeftCoords.X,
                                    this.topLeftCoords.Y,
                                    Math.Abs(this.topLeftCoords.X - this.bottomRightCoords.X),
                                    Math.Abs(this.topLeftCoords.Y - this.bottomRightCoords.Y));

        }
    }
}
