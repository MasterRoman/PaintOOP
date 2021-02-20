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

namespace PaintOOP
{
    public partial class Controller : Form
    {
        private List<FigureFactory> factoryList;
        private ListFigure figureList;
        private IFactory curFactory;

        public Controller()
        {
            InitializeComponent();
        }

        private void Controller_Load(object sender, EventArgs e)
        {
            this.factoryList = new List<FigureFactory>();
            this.figureList = new ListFigure();
            this.curFactory = null;

         //   var lineFactory
            var rectFactory = new RectangleFactory();
            //    var ellipseFactory
            //    var poligonFactory

            this.factoryList.Add(rectFactory);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            MainView.cleanScreen(e, 0, 0,this.pictureBox.Height, this.pictureBox.Width);
            MainView.drawFigures(e,this.figureList); //will complete

        }

        private void fontToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            //TODO:change line size of current figure
        }

        private void colorChangeToolStripButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // set control backColor
            this.colorChangeToolStripButton.BackColor = colorDialog.Color;

            //TODO: set line color
        }

        private void fillColorChangeToolStripButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // set control backColor
            this.fillColorChangeToolStripButton.BackColor = colorDialog.Color;

            //TODO: set fill color
        }

        private void instrumentToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripButton item in this.instrumentToolStrip.Items)
            {
                if (item == e.ClickedItem)
                {
                    item.CheckState = CheckState.Checked;
                    this.curFactory = this.factoryList[0];
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

       
    }
}
