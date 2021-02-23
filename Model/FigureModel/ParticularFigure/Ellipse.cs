using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintOOP.Model.PaintingModel;
using PaintOOP.Services;

namespace PaintOOP.Model.FigureModel.ParticularFigure
{
    class Ellipse : StaticFigure
    {

        public Ellipse(System.Drawing.Point points, IPaintingProperty paintingProperty)
        {

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

            System.Drawing.Rectangle rect = Helper.makeCoordsForDrawing(this.topLeftCoords, this.bottomRightCoords);

            e.Graphics.FillEllipse(brush, rect);

            e.Graphics.DrawEllipse(pen, rect);

        }

    }


    public class EllipseFactory : FigureFactory
    {
        public override IFigure create(System.Drawing.Point points, IPaintingProperty paintingProperty)
        {
            return new Ellipse(points, paintingProperty);
        }
    }
}
