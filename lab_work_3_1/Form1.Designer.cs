namespace lab_work_3_1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.eraserButton = new System.Windows.Forms.ToolStripButton();
            this.pencilButton = new System.Windows.Forms.ToolStripButton();
            this.brushButton = new System.Windows.Forms.ToolStripButton();
            this.fillButton = new System.Windows.Forms.ToolStripButton();
            this.textButton = new System.Windows.Forms.ToolStripButton();
            this.rectangleButton = new System.Windows.Forms.ToolStripButton();
            this.ellipseButton = new System.Windows.Forms.ToolStripButton();
            this.polygonButton = new System.Windows.Forms.ToolStripButton();
            this.lineButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripColor = new System.Windows.Forms.ToolStrip();
            this.buttonColor = new System.Windows.Forms.ToolStripButton();
            this.buttonColor1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.brushComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.paintPanel = new System.Windows.Forms.PictureBox();
            this.lineSize = new System.Windows.Forms.NumericUpDown();
            this.curveButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip.SuspendLayout();
            this.toolStripColor.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineSize)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eraserButton,
            this.pencilButton,
            this.brushButton,
            this.fillButton,
            this.textButton,
            this.rectangleButton,
            this.ellipseButton,
            this.polygonButton,
            this.lineButton,
            this.curveButton});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 46);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(46, 469);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // eraserButton
            // 
            this.eraserButton.AutoSize = false;
            this.eraserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraserButton.Image = ((System.Drawing.Image)(resources.GetObject("eraserButton.Image")));
            this.eraserButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eraserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraserButton.Margin = new System.Windows.Forms.Padding(3);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(30, 30);
            this.eraserButton.Click += new System.EventHandler(this.toolCheckdUncheckd);
            // 
            // pencilButton
            // 
            this.pencilButton.AutoSize = false;
            this.pencilButton.Checked = true;
            this.pencilButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pencilButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pencilButton.Image = ((System.Drawing.Image)(resources.GetObject("pencilButton.Image")));
            this.pencilButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pencilButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pencilButton.Margin = new System.Windows.Forms.Padding(3);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Size = new System.Drawing.Size(30, 30);
            this.pencilButton.Click += new System.EventHandler(this.toolCheckdUncheckd);
            // 
            // brushButton
            // 
            this.brushButton.AutoSize = false;
            this.brushButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brushButton.Image = ((System.Drawing.Image)(resources.GetObject("brushButton.Image")));
            this.brushButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.brushButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brushButton.Margin = new System.Windows.Forms.Padding(3);
            this.brushButton.Name = "brushButton";
            this.brushButton.Size = new System.Drawing.Size(30, 30);
            this.brushButton.Click += new System.EventHandler(this.toolCheckdUncheckd);
            // 
            // fillButton
            // 
            this.fillButton.AutoSize = false;
            this.fillButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillButton.Image = ((System.Drawing.Image)(resources.GetObject("fillButton.Image")));
            this.fillButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fillButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillButton.Margin = new System.Windows.Forms.Padding(3);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(30, 30);
            this.fillButton.Click += new System.EventHandler(this.toolCheckdUncheckd);
            // 
            // textButton
            // 
            this.textButton.AutoSize = false;
            this.textButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textButton.Image = ((System.Drawing.Image)(resources.GetObject("textButton.Image")));
            this.textButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.textButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textButton.Margin = new System.Windows.Forms.Padding(3);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(30, 30);
            this.textButton.Click += new System.EventHandler(this.toolCheckdUncheckd);
            // 
            // rectangleButton
            // 
            this.rectangleButton.AutoSize = false;
            this.rectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("rectangleButton.Image")));
            this.rectangleButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectangleButton.Margin = new System.Windows.Forms.Padding(3);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(30, 30);
            this.rectangleButton.Click += new System.EventHandler(this.toolCheckdUncheckd);
            // 
            // ellipseButton
            // 
            this.ellipseButton.AutoSize = false;
            this.ellipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipseButton.Image = ((System.Drawing.Image)(resources.GetObject("ellipseButton.Image")));
            this.ellipseButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ellipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipseButton.Margin = new System.Windows.Forms.Padding(3);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(30, 30);
            this.ellipseButton.Click += new System.EventHandler(this.toolCheckdUncheckd);
            // 
            // polygonButton
            // 
            this.polygonButton.AutoSize = false;
            this.polygonButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.polygonButton.Image = ((System.Drawing.Image)(resources.GetObject("polygonButton.Image")));
            this.polygonButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.polygonButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.polygonButton.Margin = new System.Windows.Forms.Padding(3);
            this.polygonButton.Name = "polygonButton";
            this.polygonButton.Size = new System.Drawing.Size(30, 30);
            this.polygonButton.Click += new System.EventHandler(this.toolCheckdUncheckd);
            // 
            // lineButton
            // 
            this.lineButton.AutoSize = false;
            this.lineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineButton.Image = ((System.Drawing.Image)(resources.GetObject("lineButton.Image")));
            this.lineButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineButton.Margin = new System.Windows.Forms.Padding(3);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(30, 30);
            this.lineButton.Click += new System.EventHandler(this.toolCheckdUncheckd);
            // 
            // toolStripColor
            // 
            this.toolStripColor.AutoSize = false;
            this.toolStripColor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripColor.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripColor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonColor,
            this.buttonColor1,
            this.toolStripButton15,
            this.toolStripButton14,
            this.toolStripButton13,
            this.toolStripButton12,
            this.toolStripButton11,
            this.toolStripButton10,
            this.toolStripButton9,
            this.toolStripButton8,
            this.toolStripButton7,
            this.toolStripButton6,
            this.toolStripButton5,
            this.toolStripButton4,
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton1});
            this.toolStripColor.Location = new System.Drawing.Point(0, 515);
            this.toolStripColor.Name = "toolStripColor";
            this.toolStripColor.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripColor.Size = new System.Drawing.Size(784, 46);
            this.toolStripColor.TabIndex = 2;
            this.toolStripColor.Text = "toolStripColor";
            // 
            // buttonColor
            // 
            this.buttonColor.AutoSize = false;
            this.buttonColor.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.buttonColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonColor.Margin = new System.Windows.Forms.Padding(3);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(40, 40);
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor1
            // 
            this.buttonColor1.AutoSize = false;
            this.buttonColor1.BackColor = System.Drawing.Color.Black;
            this.buttonColor1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.buttonColor1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonColor1.Margin = new System.Windows.Forms.Padding(3);
            this.buttonColor1.Name = "buttonColor1";
            this.buttonColor1.Size = new System.Drawing.Size(24, 24);
            this.buttonColor1.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.AutoSize = false;
            this.toolStripButton15.BackColor = System.Drawing.Color.Silver;
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton15.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton15.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.AutoSize = false;
            this.toolStripButton14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton14.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.AutoSize = false;
            this.toolStripButton13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton13.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.AutoSize = false;
            this.toolStripButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton12.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.AutoSize = false;
            this.toolStripButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton11.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.AutoSize = false;
            this.toolStripButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton10.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.AutoSize = false;
            this.toolStripButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton9.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.AutoSize = false;
            this.toolStripButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton8.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.AutoSize = false;
            this.toolStripButton7.BackColor = System.Drawing.Color.Red;
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton7.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.AutoSize = false;
            this.toolStripButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.BackColor = System.Drawing.Color.Yellow;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.BackColor = System.Drawing.Color.Lime;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.BackColor = System.Drawing.Color.Cyan;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackColor = System.Drawing.Color.Blue;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackColor = System.Drawing.Color.Fuchsia;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.AutoSize = false;
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.openButton,
            this.saveButton,
            this.toolStripSeparator1,
            this.brushComboBox});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMenu.Size = new System.Drawing.Size(784, 46);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStripMenu";
            // 
            // newButton
            // 
            this.newButton.AutoSize = false;
            this.newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
            this.newButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButton.Margin = new System.Windows.Forms.Padding(5);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(40, 40);
            this.newButton.Text = "Создать";
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // openButton
            // 
            this.openButton.AutoSize = false;
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Margin = new System.Windows.Forms.Padding(5);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(40, 40);
            this.openButton.Text = "Открыть";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = false;
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Margin = new System.Windows.Forms.Padding(5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(40, 40);
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // brushComboBox
            // 
            this.brushComboBox.AutoSize = false;
            this.brushComboBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.brushComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brushComboBox.DropDownWidth = 250;
            this.brushComboBox.Enabled = false;
            this.brushComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.brushComboBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brushComboBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.brushComboBox.IntegralHeight = false;
            this.brushComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.brushComboBox.Name = "brushComboBox";
            this.brushComboBox.Size = new System.Drawing.Size(150, 31);
            this.brushComboBox.ToolTipText = "Толшина линий";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JPG |*.jpg|PNG|*.png|BMP|*.bmp|GIF|*.gif";
            // 
            // paintPanel
            // 
            this.paintPanel.BackColor = System.Drawing.Color.White;
            this.paintPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintPanel.InitialImage = null;
            this.paintPanel.Location = new System.Drawing.Point(46, 46);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Size = new System.Drawing.Size(738, 469);
            this.paintPanel.TabIndex = 3;
            this.paintPanel.TabStop = false;
            this.paintPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseDown);
            this.paintPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseMove);
            this.paintPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseUp);
            // 
            // lineSize
            // 
            this.lineSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineSize.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lineSize.Location = new System.Drawing.Point(319, 7);
            this.lineSize.Name = "lineSize";
            this.lineSize.Size = new System.Drawing.Size(50, 31);
            this.lineSize.TabIndex = 6;
            this.lineSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.lineSize.ValueChanged += new System.EventHandler(this.lineSize_ValueChanged);
            // 
            // curveButton
            // 
            this.curveButton.AutoSize = false;
            this.curveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.curveButton.Image = ((System.Drawing.Image)(resources.GetObject("curveButton.Image")));
            this.curveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.curveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.curveButton.Margin = new System.Windows.Forms.Padding(3);
            this.curveButton.Name = "curveButton";
            this.curveButton.Size = new System.Drawing.Size(30, 30);
            this.curveButton.Visible = false;
            this.curveButton.Click += new System.EventHandler(this.toolCheckdUncheckd);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPG |*.jpg|PNG|*.png|BMP|*.bmp|GIF|*.gif";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.paintPanel);
            this.Controls.Add(this.lineSize);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.toolStripColor);
            this.Controls.Add(this.toolStripMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.toolStripColor.ResumeLayout(false);
            this.toolStripColor.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStrip toolStripColor;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton buttonColor;
        private System.Windows.Forms.ToolStripButton buttonColor1;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton eraserButton;
        private System.Windows.Forms.ToolStripButton fillButton;
        private System.Windows.Forms.ToolStripButton pencilButton;
        private System.Windows.Forms.ToolStripButton brushButton;
        private System.Windows.Forms.ToolStripButton rectangleButton;
        private System.Windows.Forms.ToolStripButton ellipseButton;
        private System.Windows.Forms.ToolStripButton polygonButton;
        private System.Windows.Forms.ToolStripButton lineButton;
        private System.Windows.Forms.ToolStripButton textButton;
        private System.Windows.Forms.ToolStripButton newButton;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox paintPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox brushComboBox;
        private System.Windows.Forms.NumericUpDown lineSize;
        private System.Windows.Forms.ToolStripButton curveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

