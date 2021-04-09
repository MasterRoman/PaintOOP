
namespace PaintOOP
{
    partial class Controller
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controller));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.addFigureButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.instrumentToolStrip = new System.Windows.Forms.ToolStrip();
            this.lineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rectangleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.redoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lineSizeChangeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.colorChangeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.fillColorChangeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.mainMenuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.instrumentToolStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(1163, 28);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(214, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F12)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.saveAsToolStripMenuItem.Text = "Save as ";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.addFigureButton);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.instrumentToolStrip);
            this.panel.Controls.Add(this.mainToolStrip);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 28);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1163, 498);
            this.panel.TabIndex = 2;
            // 
            // addFigureButton
            // 
            this.addFigureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addFigureButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFigureButton.Location = new System.Drawing.Point(0, 424);
            this.addFigureButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFigureButton.Name = "addFigureButton";
            this.addFigureButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addFigureButton.Size = new System.Drawing.Size(51, 50);
            this.addFigureButton.TabIndex = 5;
            this.addFigureButton.TabStop = false;
            this.addFigureButton.Text = "+";
            this.addFigureButton.UseVisualStyleBackColor = true;
            this.addFigureButton.Click += new System.EventHandler(this.addFigureButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(53, 43);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1050, 500);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Tag = "0";
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // instrumentToolStrip
            // 
            this.instrumentToolStrip.AutoSize = false;
            this.instrumentToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.instrumentToolStrip.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.instrumentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripButton,
            this.rectangleToolStripButton,
            this.toolStripButton4,
            this.toolStripButton5});
            this.instrumentToolStrip.Location = new System.Drawing.Point(0, 43);
            this.instrumentToolStrip.Name = "instrumentToolStrip";
            this.instrumentToolStrip.Size = new System.Drawing.Size(51, 500);
            this.instrumentToolStrip.TabIndex = 2;
            this.instrumentToolStrip.Text = "toolStrip1";
            this.instrumentToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.instrumentToolStrip_ItemClicked);
            // 
            // lineToolStripButton
            // 
            this.lineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("lineToolStripButton.Image")));
            this.lineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineToolStripButton.Name = "lineToolStripButton";
            this.lineToolStripButton.Size = new System.Drawing.Size(49, 34);
            this.lineToolStripButton.Tag = "0";
            this.lineToolStripButton.Text = "toolStripButton2";
            // 
            // rectangleToolStripButton
            // 
            this.rectangleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectangleToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("rectangleToolStripButton.Image")));
            this.rectangleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectangleToolStripButton.Name = "rectangleToolStripButton";
            this.rectangleToolStripButton.Size = new System.Drawing.Size(49, 34);
            this.rectangleToolStripButton.Tag = "1";
            this.rectangleToolStripButton.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(49, 34);
            this.toolStripButton4.Tag = "2";
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(49, 34);
            this.toolStripButton5.Tag = "3";
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.AutoSize = false;
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7,
            this.toolStripSeparator1,
            this.undoToolStripButton,
            this.redoToolStripButton,
            this.toolStripSeparator2,
            this.lineSizeChangeToolStripTextBox,
            this.toolStripSeparator3,
            this.colorChangeToolStripButton,
            this.toolStripSeparator4,
            this.fillColorChangeToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(1142, 43);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "mainToolStrip";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 40);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 40);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(34, 40);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // undoToolStripButton
            // 
            this.undoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoToolStripButton.Enabled = false;
            this.undoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripButton.Image")));
            this.undoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoToolStripButton.Name = "undoToolStripButton";
            this.undoToolStripButton.Size = new System.Drawing.Size(34, 40);
            this.undoToolStripButton.Text = "toolStripButton10";
            this.undoToolStripButton.Click += new System.EventHandler(this.undoToolStripButton_Click);
            // 
            // redoToolStripButton
            // 
            this.redoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoToolStripButton.Enabled = false;
            this.redoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripButton.Image")));
            this.redoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoToolStripButton.Name = "redoToolStripButton";
            this.redoToolStripButton.Size = new System.Drawing.Size(34, 40);
            this.redoToolStripButton.Text = "toolStripButton11";
            this.redoToolStripButton.Click += new System.EventHandler(this.redoToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // lineSizeChangeToolStripTextBox
            // 
            this.lineSizeChangeToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lineSizeChangeToolStripTextBox.Name = "lineSizeChangeToolStripTextBox";
            this.lineSizeChangeToolStripTextBox.Size = new System.Drawing.Size(40, 43);
            this.lineSizeChangeToolStripTextBox.Text = "6";
            this.lineSizeChangeToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lineSizeChangeToolStripTextBox.TextChanged += new System.EventHandler(this.fontToolStripTextBox_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // colorChangeToolStripButton
            // 
            this.colorChangeToolStripButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorChangeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.colorChangeToolStripButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colorChangeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("colorChangeToolStripButton.Image")));
            this.colorChangeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.colorChangeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorChangeToolStripButton.Name = "colorChangeToolStripButton";
            this.colorChangeToolStripButton.Size = new System.Drawing.Size(100, 40);
            this.colorChangeToolStripButton.Text = "Set line color";
            this.colorChangeToolStripButton.Click += new System.EventHandler(this.colorChangeToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 43);
            // 
            // fillColorChangeToolStripButton
            // 
            this.fillColorChangeToolStripButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fillColorChangeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillColorChangeToolStripButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fillColorChangeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fillColorChangeToolStripButton.Image")));
            this.fillColorChangeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fillColorChangeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillColorChangeToolStripButton.Name = "fillColorChangeToolStripButton";
            this.fillColorChangeToolStripButton.Size = new System.Drawing.Size(93, 40);
            this.fillColorChangeToolStripButton.Text = "Set fill color";
            this.fillColorChangeToolStripButton.Click += new System.EventHandler(this.fillColorChangeToolStripButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 526);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Controller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Controller_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.instrumentToolStrip.ResumeLayout(false);
            this.instrumentToolStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStrip instrumentToolStrip;
        private System.Windows.Forms.ToolStripButton lineToolStripButton;
        private System.Windows.Forms.ToolStripButton rectangleToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button addFigureButton;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton undoToolStripButton;
        private System.Windows.Forms.ToolStripButton redoToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripTextBox lineSizeChangeToolStripTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton colorChangeToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton fillColorChangeToolStripButton;
    }
}

