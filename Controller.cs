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

namespace PaintOOP
{
    public partial class Controller : Form
    {
        private List<FigureFactory> factoryList;
        private ListFigure figureList;

        public Controller()
        {
            InitializeComponent();
        }

        private void Controller_Load(object sender, EventArgs e)
        {
            this.factoryList = new List<FigureFactory>();
            this.figureList = new ListFigure();
            
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
            //TODO: configure button with information from dll

            ToolStripButton button = new ToolStripButton();
            button.Text = "NEW";
            button.AutoSize = false;
            button.Size = new Size(36, 34);
            button.DisplayStyle = ToolStripItemDisplayStyle.Text;

            //button.Image = ((System.Drawing.Image)(resources.GetObject("pointerToolStripButton.Image")));

            button.ImageTransparentColor = Color.Magenta;


            this.instrumentToolStrip.Items.Add(button);
        }

       
    }
}
