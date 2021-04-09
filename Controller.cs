using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using PaintOOP.View;
using PaintOOP.Model;
using PaintOOP.Model.FigureModel.ParticularFigure;
using PaintOOP.Services;
using PaintOOP.Model.SerializeModel;

using System.Reflection;

namespace PaintOOP
{
    public partial class Controller : Form
    {
        private List<IFactory<IFigure>> factoryList;
        private ListFigure figureList;
        private IFactory<IFigure> curFactory;
        private IFigure curFigure;
        private PaintingProperty paintingProperty;
        private List<Type> dllTypes;


        public Controller()
        {
            InitializeComponent();
        }

        private void Controller_Load(object sender, EventArgs e)
        {
            this.factoryList = new List<IFactory<IFigure>>();
            this.figureList = new ListFigure();
            this.curFactory = null;
            this.curFigure = null;
            this.paintingProperty = new PaintingProperty();
            this.dllTypes = new List<Type>();

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


            var lineFactory = new LineFactory();
            var rectFactory = new RectangleFactory();
            var ellipseFactory = new EllipseFactory();
            var poligonFactory = new PolygonFactory();

            this.factoryList.Add(lineFactory);
            this.factoryList.Add(rectFactory);
            this.factoryList.Add(ellipseFactory);
            this.factoryList.Add(poligonFactory);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            MainView.cleanScreen(e, 0, 0, this.pictureBox.Height, this.pictureBox.Width);
            MainView.drawFigures(e, this.figureList); //will complete

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
                    int number = Int32.Parse(item.Tag.ToString());
                    if (number < this.factoryList.Count)
                    {
                        this.curFactory = this.factoryList[number];
                    }
                }
                else
                {
                    item.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void addFigureButton_Click(object sender, EventArgs e)
        {

            //button.Image = ((System.Drawing.Image)(resources.GetObject("pointerToolStripButton.Image")));

            try
            {
                openFileDialog.ShowDialog();
                String path = openFileDialog.FileName;

                Assembly dll = Assembly.LoadFile(path);

                foreach (Type type in dll.GetExportedTypes())
                {
                    var isAssignable = typeof(IFigure).IsAssignableFrom(type);
                    if (isAssignable)
                    {
                        dllTypes.Add(type);
                    }
                    isAssignable = typeof(IFactory<IFigure>).IsAssignableFrom(type);
                    if (isAssignable)
                    {
                        IFactory<IFigure> factory = (IFactory<IFigure>)Activator.CreateInstance(type);
                        this.factoryList.Add(factory);

                        ToolStripButton button = new ToolStripButton();
                        button.Text = this.dllTypes.Last().Name.ToString().Substring(0,4);
                        button.Font = new Font(FontFamily.GenericSansSerif,(float)10.0);
                        button.AutoSize = false;
                        button.Size = new Size(36, 34);
                        button.DisplayStyle = ToolStripItemDisplayStyle.Text;
                        button.Tag = this.factoryList.Count - 1;
                        button.ImageTransparentColor = Color.Magenta;

                        this.instrumentToolStrip.Items.Add(button);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //mouse events 

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.curFactory != null)
            {
                this.undoToolStripButton.Enabled = true;
                if (this.redoToolStripButton.Enabled)
                {
                    this.figureList.setRedoNil();
                    this.redoToolStripButton.Enabled = false;
                }


                var points = new Point(e.X, e.Y);
                if (e.Button == MouseButtons.Left)
                {
                    if (this.curFigure == null)
                    {
                        this.curFigure = this.curFactory.create(points, this.paintingProperty);
                        this.figureList.Add(this.curFigure);                                      //adding new figure
                    }

                    this.curFigure.addPoints(points);
                }
                else if (this.curFigure != null && e.Button == MouseButtons.Right)
                {

                    this.curFigure.addPoints(points);
                    this.curFigure.closeFigure();
                    this.curFigure = null;                       //stop drawing figure

                }
                this.pictureBox.Invalidate();
            }

        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.curFigure != null)
            {
                var points = new Point(e.X, e.Y);
                this.curFigure.changeLastPoints(points);  //preview of figures
                this.pictureBox.Invalidate();
            }

        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void undoToolStripButton_Click(object sender, EventArgs e)
        {
            this.figureList.undo();
            if (this.figureList.Count == 0)
            {
                this.undoToolStripButton.Enabled = false;
            }
            this.redoToolStripButton.Enabled = true;
            this.pictureBox.Invalidate();
        }

        private void redoToolStripButton_Click(object sender, EventArgs e)
        {
            this.figureList.redo();
            if (this.figureList.undoFigures.Count == 0)
            {
                this.redoToolStripButton.Enabled = false;
                this.undoToolStripButton.Enabled = true;
            }
            this.pictureBox.Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actOpen();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            actOpen();
        }

        private void actOpen()
        {
            openFileDialog.ShowDialog();
            String path = openFileDialog.FileName;

            if (path.Length != 0)
            {

                this.figureList.Clear();
                this.figureList.cleanUndoList();

                string json = "";
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        json = sr.ReadToEnd();
                    }

                    //deserialize 
                    List<Wrapper> wrapperList = JsonSerializer.Deserialize<List<Wrapper>>(json);

                    IFigure figure = null;

                    foreach (Wrapper wrapper in wrapperList)
                    {
                        var type = wrapper.type;

                        foreach (Type dllType in this.dllTypes)
                        {
                            if (dllType.ToString() == type)
                            {
                                figure = (IFigure)Activator.CreateInstance(dllType);
                            }
                        }



                        try
                        {

                            if (figure == null)
                                figure = (IFigure)Activator.CreateInstance(Type.GetType(type));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            continue;
                        }




                        this.figureList.Add(figure.deserialize(wrapper.data));

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.pictureBox.Invalidate();
            }
        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actSaveAs();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            actSaveAs();
        }

        private void actSaveAs()
        {
            saveFileDialog.ShowDialog();
            String path = saveFileDialog.FileName;
            string json = "[";
            string temp = "";
            if (path.Length != 0)
            {
                //serialize 
                try
                {
                    foreach (IFigure fig in figureList)
                    {
                        temp = fig.serialize();
                        Wrapper wrapper = new Wrapper(fig.GetType().ToString(), temp);
                        json += JsonSerializer.Serialize<Wrapper>(wrapper, null);

                        json += ",";
                    }

                    json = json.Remove(json.Length - 1);
                    json += "]";


                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.Write(json);
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            actNew();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actNew();
        }

        private void actNew()
        {
            this.figureList.Clear();
            this.figureList.cleanUndoList();

            this.pictureBox.Invalidate();
        }
    }
}
