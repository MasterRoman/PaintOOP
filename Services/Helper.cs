using System;
using System.Drawing;

namespace PaintOOP.Services
{
    public static class Helper
    {
        public static Rectangle makeCoordsForDrawing(Point topLeftCoords, Point bottomRightCoords)
        {
            int width = Math.Abs(topLeftCoords.X - bottomRightCoords.X);
            int height = Math.Abs(topLeftCoords.Y - bottomRightCoords.Y);

            Rectangle rect;

            if (topLeftCoords.X < bottomRightCoords.X)
            {
                if (topLeftCoords.Y < bottomRightCoords.Y)
                {
                    rect = new Rectangle(topLeftCoords.X, topLeftCoords.Y, width, height);
                }
                else
                {
                    rect = new Rectangle(topLeftCoords.X, bottomRightCoords.Y, width, height);
                }
            }
            else
            {
                if (topLeftCoords.Y < bottomRightCoords.Y)
                {
                    rect = new Rectangle(bottomRightCoords.X, topLeftCoords.Y, width, height);
                }
                else
                {
                    rect = new Rectangle(bottomRightCoords.X, bottomRightCoords.Y, width, height);
                }
            }
            return rect;
        }
    }
}
