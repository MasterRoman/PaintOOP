using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;
using PaintOOP.Model.PaintingModel;
using PaintOOP.Model.SerializeModel;

namespace PaintOOP.Model
{

    public interface IFigure : ISerialization<IFigure>
    {
        void drawFigure(System.Windows.Forms.PaintEventArgs e);

        void addPoints(System.Drawing.Point points);
        void closeFigure();
        void changeLastPoints(System.Drawing.Point points);

    }



    public abstract class Figure : IFigure
    {
        public abstract void drawFigure(System.Windows.Forms.PaintEventArgs e);

        public Figure()
        {

        }
        public LineConfiguration pen { get; set; }

        public FillConfiguration brush { get; set; }

        public abstract void addPoints(System.Drawing.Point points);

        public abstract void closeFigure();

        public abstract void changeLastPoints(System.Drawing.Point points);

        public virtual string serialize()
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new ColorJsonConverter());
            return JsonSerializer.Serialize(this, this.GetType(), options);
        }

        public virtual IFigure deserialize(string json)
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new ColorJsonConverter());
            return (IFigure)JsonSerializer.Deserialize(json, this.GetType(), options);
        }
    }

    public abstract class StaticFigure : Figure
    {

        public System.Drawing.Point topLeftCoords { get; set; }
        public System.Drawing.Point bottomRightCoords { get; set; }


        public override void changeLastPoints(Point points)
        {
            this.bottomRightCoords = points;
        }

        public override void addPoints(Point points)
        {

        }

        public override void closeFigure()
        {

        }
    }

    public abstract class DynamicFigure : Figure
    {
        public List<System.Drawing.Point> points { get; set; }

        public override void changeLastPoints(Point points)
        {
            this.points[this.points.Count - 1] = points;
        }

        public override void addPoints(Point points)
        {
            this.points.Add(points);
        }

        public abstract override void closeFigure();

    }

}
