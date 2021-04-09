namespace PaintOOP.Model.PaintingModel
{

    public struct LineConfiguration
    {
        public int width { get; set; }
        public System.Drawing.Color color { get; set; }
        public System.Drawing.Drawing2D.DashStyle style { get; set; }
    }
    public struct FillConfiguration
    {
        public System.Drawing.Color color { get; set; }
    }

    public interface IPaintingProperty
    {
        LineConfiguration penProperty { get; set; }
        FillConfiguration brushProperty { get; set; }
    }
}
