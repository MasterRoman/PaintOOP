using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintOOP.Model.PaintingModel;

namespace PaintOOP.Model.FigureModel.ParticularFigure
{
    public class Line : OpenedFigure
    {
        public Line(System.Drawing.Point points, IPaintingProperty paintingProperty)
        {

            this.pen = paintingProperty.penProperty;
            this.points = new List<System.Drawing.Point>();
            this.points.Add(points);

        }

        public override void drawFigure(PaintEventArgs e)
        {

            System.Drawing.Pen pen = new System.Drawing.Pen(this.pen.color);
            pen.Width = this.pen.width;
            pen.DashStyle = this.pen.style;
            int count = this.points.Count;
            if (count > 1) {
                for (int i = 0; i < count-1; i++)
                   e.Graphics.DrawLine(pen, this.points[i], this.points[i+1]); 
            }
            
        }

        public override void addPoints(System.Drawing.Point points)
        {
            this.points.Add(points);
        }
        
    
    
    }


 

    public class LineFactory : FigureFactory
    {
        public override IFigure create(System.Drawing.Point points, IPaintingProperty paintingProperty)
        {
            return new Line(points, paintingProperty);
        }
    }
}
