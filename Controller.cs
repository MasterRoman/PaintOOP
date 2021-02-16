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

namespace PaintOOP
{
    public partial class Controller : Form
    {
        public Controller()
        {
            InitializeComponent();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            MainView.cleanScreen(e, 0, 0,this.pictureBox.Height, this.pictureBox.Width);
            MainView.drawFigures(e); //will complete

        }
    }
}
