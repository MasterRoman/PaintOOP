using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PaintOOP.View
{
    public static class MainView
    {
        public static void cleanScreen(System.Windows.Forms.PaintEventArgs e,int x,int y,int height,int width)
        {
            Brush brush = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(brush, x, y,width,height);
        }

        public static void drawFigures(System.Windows.Forms.PaintEventArgs e) //will complete after declare model
        {

        }

        public static void drawVertexOnSelectedFigures(System.Windows.Forms.PaintEventArgs e,Point points,Color color) // will complete later
        {

        }
        public static void drawSelectedRect(System.Windows.Forms.PaintEventArgs e,Rectangle rect)
        {
            Pen pen = new Pen(Color.Black);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            if ((rect.Right > rect.Left) && (rect.Top > rect.Bottom))
                e.Graphics.DrawRectangle(pen, rect.Left, rect.Bottom, (rect.Right - rect.Left), (rect.Top - rect.Bottom));
            else if ((rect.Left > rect.Right) && (rect.Bottom > rect.Top))
                e.Graphics.DrawRectangle(pen, rect.Right, rect.Top, (rect.Left - rect.Right), (rect.Bottom - rect.Top));
            else if (rect.Right > rect.Left)
                e.Graphics.DrawRectangle(pen, rect.Left, rect.Top, (rect.Right - rect.Left), (rect.Bottom - rect.Top));
            else if (rect.Left > rect.Right)
                e.Graphics.DrawRectangle(pen, rect.Right, rect.Bottom, (rect.Left - rect.Right), (rect.Top - rect.Bottom));
        }
    

    }
}
