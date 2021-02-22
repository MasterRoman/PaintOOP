using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintOOP.View;
using PaintOOP.Model;
using PaintOOP.Model.FigureModel.ParticularFigure;
using PaintOOP.Services;

namespace PaintOOP
{
    public partial class Controller : Form
    {
        private List<FigureFactory> factoryList;
        private ListFigure figureList;
        private IFactory curFactory;
        private IFigure curFigure;
        private PaintingProperty paintingProperty;

       
        public Controller()
        {
            InitializeComponent();
        }

        private void Controller_Load(object sender, EventArgs e)
        {
            this.factoryList = new List<FigureFactory>();
            this.figureList = new ListFigure();
            this.curFactory = null;
            this.curFigure = null;
            this.paintingProperty = new PaintingProperty();

            var color = this.fillColorChangeToolStripButton.BackColor;
            var brush = this.paintingProperty.brushProperty;
            brush.color = color;

            this.paintingProperty.brushProperty = brush;

            var pen = this.paintingProperty.penProperty;
            pen.color = this.colorChangeToolStripButton.BackColor;
            var fontSize = this.lineSizeChangeToolStripTextBox.Text.Trim().ToString();
            pen.width = Int32.Parse(fontSize);

            pen.style = System.Drawing.Drawing2D.DashStyle.Solid;

            this.paintingProperty.penProperty = pen;


            //   var lineFactory
            var rectFactory = new RectangleFactory();
            var ellipseFactory = new EllipseFactory();
            //    var poligonFactory

            this.factoryList.Add(rectFactory);
            this.factoryList.Add(ellipseFactory);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            MainView.cleanScreen(e, 0, 0,this.pictureBox.Height, this.pictureBox.Width);
            MainView.drawFigures(e,this.figureList); //will complete

        }

        private void fontToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            var pen = this.paintingProperty.penProperty;
            var fontSize = this.lineSizeChangeToolStripTextBox.Text.Trim().ToString();
            pen.width = Int32.Parse(fontSize);

            this.paintingProperty.penProperty = pen;
        }

        private void colorChangeToolStripButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // set control backColor
            this.colorChangeToolStripButton.BackColor = colorDialog.Color;

            var pen = this.paintingProperty.penProperty;
            pen.color = this.colorChangeToolStripButton.BackColor;

            this.paintingProperty.penProperty = pen;
        }

        private void fillColorChangeToolStripButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // set control backColor
            this.fillColorChangeToolStripButton.BackColor = colorDialog.Color;

            var brush = this.paintingProperty.brushProperty;
            brush.color = this.fillColorChangeToolStripButton.BackColor;

            this.paintingProperty.brushProperty = brush;
        }

        private void instrumentToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripButton item in this.instrumentToolStrip.Items)
            {
                if (item == e.ClickedItem)
                {
                    item.CheckState = CheckState.Checked;
                    this.curFactory = this.factoryList[1];
                    // commented because not all particular classes are completed 
                    //if ((int)item.Tag < this.factoryList.Count)
                    //{
                    //    this.curFactory = this.factoryList[(int)item.Tag];
                    //}
                }
                else
                {
                    item.CheckState = CheckState.Unchecked;
                }
            }

            //TODO: set particular figure!!!

        }

        private void addFigureButton_Click(object sender, EventArgs e)
        {
            
            ToolStripButton button = new ToolStripButton();
            button.Text = "NEW";
            button.AutoSize = false;
            button.Size = new Size(36, 34);
            button.DisplayStyle = ToolStripItemDisplayStyle.Text;
            button.Tag = this.factoryList.Count;
            //button.Image = ((System.Drawing.Image)(resources.GetObject("pointerToolStripButton.Image")));

            button.ImageTransparentColor = Color.Magenta;

            //TODO: configure button with information from dll

            //add factory of new figure to list 
            //this.factoryList.Add();

            this.instrumentToolStrip.Items.Add(button);
        }

        //mouse events 

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            var points = new Point(e.X, e.Y);
            if (this.curFactory != null)
            {
                this.curFigure = this.curFactory.create(points, this.paintingProperty);
                this.figureList.Add(this.curFigure);
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.curFigure != null)
            {
                if (this.curFigure.isClosed)
                {
                    ClosedFigure figure = (ClosedFigure)this.curFigure;
                    var points = new Point(e.X, e.Y);
                    figure.bottomRightCoords = points;



                }
                this.pictureBox.Invalidate();


            }

        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.curFigure != null)
            {
                if (this.curFigure.isClosed)
                {
                    ClosedFigure figure = (ClosedFigure)this.curFigure;
                    var points = new Point(e.X, e.Y);
                    figure.bottomRightCoords = points;
                }

                this.curFigure = null;
            }

            
            this.pictureBox.Invalidate();
        }
      
    }
}
