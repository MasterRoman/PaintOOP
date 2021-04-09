using PaintOOP.Model.PaintingModel;

namespace PaintOOP.Model
{
    public interface IFactory<TFigure> where TFigure : IFigure
    {
        TFigure create(System.Drawing.Point points, IPaintingProperty paintingProperty);

    }

}
