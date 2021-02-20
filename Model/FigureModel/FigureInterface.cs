﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintOOP.Model.PaintingModel;

namespace PaintOOP.Model
{
   
    interface IFigure
    {
        void drawFigure(System.Windows.Forms.PaintEventArgs e);
        LineConfiguration pen { get; set; }
        bool isClosed { get; set; }
    }

    public abstract class Figure : IFigure
    {
        public virtual void drawFigure(System.Windows.Forms.PaintEventArgs e)
        {

        }
        public LineConfiguration pen { get; set; }
        public bool isClosed { get; set; }
    }

    public abstract class OpenedFigure : Figure
    {
        public List<System.Drawing.Point> points { get; set; }

    }

    public abstract class ClosedFigure : Figure
    {
        public System.Drawing.Point topLeftCoords { get; set; }
        public System.Drawing.Point bottomRightCoords { get; set; }
        public FillConfiguration brush { get; set;}
    }

}
