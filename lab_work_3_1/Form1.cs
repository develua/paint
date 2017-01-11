using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;

namespace lab_work_3_1
{
    public partial class Form1 : Form
    {
        List<ElementPaint> listElementPaint;
        List<ToolStripButton> listTools;
        ToolsPaint toolActive;
        Bitmap polePaint;
        TextBox textBoxPaint;
        bool mouseClick;

        public Form1()
        {
            InitializeComponent();

            mouseClick = false;
            toolActive = ToolsPaint.pencil;
            listElementPaint = new List<ElementPaint>();

            listTools = new List<ToolStripButton>()
            {
                eraserButton, fillButton, pencilButton, brushButton, rectangleButton,
                ellipseButton, polygonButton, lineButton, curveButton, textButton
            };

            paintPanel.Cursor = Cursors.Cross;

            textBoxPaint = new TextBox();
            textBoxPaint.Width = 100;
            textBoxPaint.Visible = false;
            paintPanel.Controls.Add(textBoxPaint);
            textBoxPaint.KeyDown += textBoxPaint_KeyDown;
            textBoxPaint.BorderStyle = BorderStyle.None;

            string[] strName = Enum.GetNames(typeof(HatchStyle));

            for (int i = 0; i < strName.Length; i++)
                brushComboBox.Items.Add(strName[i]);

            brushComboBox.SelectedIndex = 0;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                buttonColor.BackColor = colorDialog1.Color;
        }

        private void color_Click(object sender, EventArgs e)
        {
            buttonColor.BackColor = ((ToolStripButton)sender).BackColor;

            if (toolActive == ToolsPaint.text)
                textBoxPaint.ForeColor = buttonColor.BackColor;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            paintPanel.Image = null;
			polePaint = null;
            paintPanel.BackColor = Color.White;
            listElementPaint.Clear();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(openFileDialog1.FileName);
                paintPanel.Image = image;
                paintPanel.Width = image.Width;
                paintPanel.Height = image.Height;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            savePanelToBitmap();

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                polePaint.Save(saveFileDialog1.FileName);
        }

        private void toolCheckdUncheckd(object sender, EventArgs e)
        {
            if (toolActive == ToolsPaint.text)
                textBoxPanelPrint();

            for (int i = 0; i < listTools.Count; i++)
                listTools[i].CheckState = CheckState.Unchecked;

            ToolStripButton tsb = ((ToolStripButton)sender);
            tsb.CheckState = CheckState.Checked;
            lineSize.Text = "2";
            brushComboBox.Enabled = false;

            switch(tsb.Name)
            {
                case "eraserButton":
                    toolActive = ToolsPaint.eraser;
                    break;
                case "pencilButton":
                    toolActive = ToolsPaint.pencil;
                    break;
                case "brushButton":
                    toolActive = ToolsPaint.brush;
                    lineSize.Text = "10";
                    brushComboBox.Enabled = true;
                    break;
                case "fillButton":
                    toolActive = ToolsPaint.fill;
                    break;
                case "textButton":
                    toolActive = ToolsPaint.text;
                    lineSize.Text = "14";
                    break;
                case "rectangleButton":
                    toolActive = ToolsPaint.rectangle;
                    break;
                case "ellipseButton":
                    toolActive = ToolsPaint.ellipse;
                    break;
                case "polygonButton":
                    toolActive = ToolsPaint.polygon;
                    break;
                case "lineButton":
                    toolActive = ToolsPaint.line;
                    break;
                case "curveButton":
                    toolActive = ToolsPaint.curve;
                    break;
            }
        }

        private void savePanelToBitmap()
        {
            if (polePaint != null)
                polePaint.Dispose();

            polePaint = new Bitmap(paintPanel.Width, paintPanel.Height, PixelFormat.Format32bppRgb);
            Graphics g = Graphics.FromImage(polePaint);
            g.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rect = paintPanel.RectangleToScreen(paintPanel.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, paintPanel.Size);
            paintPanel.Image = polePaint;
        }

        private void paintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (toolActive == ToolsPaint.fill)
            {
                fillElement(e.X, e.Y);
                return;
            }

            if (listElementPaint.Count > 0)
                if (listElementPaint.Last().typeTool == ToolsPaint.text && listElementPaint.Last().text == null)
                    textBoxPanelPrint();

            if (toolActive != ToolsPaint.polygon || listElementPaint.Count == 0)
                listElementPaint.Add(new ElementPaint(toolActive, buttonColor.BackColor, Convert.ToInt32(lineSize.Text)));

            if (listElementPaint.Count != 0)
                if (listElementPaint.Last().elementClose == true)
                    listElementPaint.Add(new ElementPaint(toolActive, buttonColor.BackColor, Convert.ToInt32(lineSize.Text)));

            mouseClick = true;

            if (toolActive == ToolsPaint.text)
            {
                textBoxPaint.Clear();
                textBoxPaint.Visible = true;
                textBoxPaint.Location = new Point(e.X, e.Y);
                textBoxPaint.ForeColor = buttonColor.BackColor;
                textBoxPaint.Font = new Font("Tahoma", Convert.ToInt32(lineSize.Text));
                textBoxPaint.Focus();
            }

            if(toolActive == ToolsPaint.brush)
                listElementPaint.Last().hatchStyle = (HatchStyle)Enum.Parse(typeof(HatchStyle), brushComboBox.SelectedItem.ToString(), false);
        }

        private void paintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (toolActive != ToolsPaint.polygon || toolActive == ToolsPaint.polygon && listElementPaint.Last().elementClose == true)
                mouseClick = false;

            if (toolActive == ToolsPaint.polygon && listElementPaint.Last().countPoints >= 0)
            {
                listElementPaint.Last().countPoints++;

                if (listElementPaint.Last().listPoints.Count > 3)
                {
                    List<Point> lp = listElementPaint.Last().listPoints;
                    int ls = Convert.ToInt32(lineSize.Value) / 2 + 1;

                    for (int i = 0; i < lp.Count - 1; i++)
                        if (lp[i].X - ls <= lp[lp.Count - 1].X && lp[i].X + ls >= lp[lp.Count - 1].X && lp[i].Y - ls <= lp[lp.Count - 1].Y && lp[i].Y + ls >= lp[lp.Count - 1].Y)
                        {
                            listElementPaint.Last().elementClose = true;
                            mouseClick = false;
                            break;
                        }
                }
            }

            if (toolActive != ToolsPaint.text)
                savePanelToBitmap();
        }

        private void paintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClick == true)
            {
                if (toolActive == ToolsPaint.rectangle || toolActive == ToolsPaint.ellipse || toolActive == ToolsPaint.line || toolActive == ToolsPaint.polygon)
                {
                    listElementPaint.Last().PointRemove();
                    paintPanel.Image = polePaint;
                    paintPanel.Update();
                }

                if (toolActive != ToolsPaint.text)
                {
                    listElementPaint.Last().listPoints.Add(new Point(e.X, e.Y));
                    listElementPaint.Last().PrintElementPaint(paintPanel.CreateGraphics());
                }
            }
        }

        private void textBoxPaint_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBoxPaint.Width <= textBoxPaint.Text.Length * textBoxPaint.Font.Size)
                textBoxPaint.Size += new Size(Convert.ToInt32(textBoxPaint.Font.Size), 0);

            if(e.KeyCode == Keys.Enter)
                textBoxPanelPrint();
        }

        private void lineSize_ValueChanged(object sender, EventArgs e)
        {
            if (toolActive == ToolsPaint.text)
                textBoxPaint.Font = new Font("Tahoma", Convert.ToInt32(lineSize.Value));
        }

        private void textBoxPanelPrint()
        {
            listElementPaint.Last().text = textBoxPaint.Text;
            listElementPaint.Last().listPoints.Add(new Point(textBoxPaint.Location.X - 3, textBoxPaint.Location.Y));
            listElementPaint.Last().listPoints.Add(new Point(textBoxPaint.Location.X, textBoxPaint.Location.Y));
            listElementPaint.Last().lineSize = Convert.ToInt32(lineSize.Value);
            listElementPaint.Last().color = buttonColor.BackColor;
            textBoxPaint.Visible = false;
            paintPanel.Update();
            listElementPaint.Last().PrintElementPaint(paintPanel.CreateGraphics());
            savePanelToBitmap();
        }

        private void fillElement(int x, int y)
        {
            Point point = new Point(x, y);
            int count = 0;

            for (int i = listElementPaint.Count - 1; i >= 0; i--)
            {
                GraphicsPath path = new GraphicsPath();

                if (listElementPaint[i].listPoints.Count > 3)
                    path.AddLines(listElementPaint[i].listPoints.ToArray());
                else if (listElementPaint[i].listPoints.Count > 1)
                {
                    Point[] p = listElementPaint[i].listPoints.ToArray();
                    int xMin = Math.Min(p[0].X, p[1].X);
                    int yMin = Math.Min(p[0].Y, p[1].Y);
                    int xMax = Math.Max(p[0].X, p[1].X);
                    int yMax = Math.Max(p[0].Y, p[1].Y);

                    if (listElementPaint[i].typeTool == ToolsPaint.rectangle)
                        path.AddRectangle(new Rectangle(xMin, yMin, xMax - xMin, yMax - yMin));
                    else if (listElementPaint[i].typeTool == ToolsPaint.ellipse)
                        path.AddEllipse(new Rectangle(xMin, yMin, xMax - xMin, yMax - yMin));
                    else if (listElementPaint[i].typeTool == ToolsPaint.polygon)
                        path.AddPolygon(listElementPaint[i].listPoints.ToArray());
                }

                if (path.IsVisible(point) && listElementPaint[i].typeTool != ToolsPaint.eraser && listElementPaint[i].typeTool != ToolsPaint.brush && listElementPaint[i].typeTool != ToolsPaint.pencil)
                {
                    listElementPaint[i].fill = true;
                    listElementPaint[i].color = buttonColor.BackColor;
                    listElementPaint[i].PrintElementPaint(paintPanel.CreateGraphics());
                    count++;
                }
            }

            if (count == 0)
            {
                paintPanel.CreateGraphics().Clear(buttonColor.BackColor);

                for (int i = 0; i < listElementPaint.Count; i++)
                {
                    if (listElementPaint[i].typeTool == ToolsPaint.eraser)
                        listElementPaint[i].color = buttonColor.BackColor;
                    else if (listElementPaint[i].typeTool != ToolsPaint.brush)
                        listElementPaint[i].PrintElementPaint(paintPanel.CreateGraphics());
                    else
                        listElementPaint[i].PrintResetBrush(paintPanel.CreateGraphics(), paintPanel.BackColor);
                }

                savePanelToBitmap();
            }
        }
    }

    public enum ToolsPaint { eraser, pencil, brush, fill, text, rectangle, ellipse, polygon, line, curve }

    public class ElementPaint
    {
        public ToolsPaint typeTool { get; private set; }
        public List<Point> listPoints { get; private set; }
        public float lineSize { get; set; }
        public Color color { get; set; }
        public HatchStyle hatchStyle { get; set; }
        public string text { get; set; }
        public bool fill { get; set; }
        public bool elementClose { get; set; }
        public int countPoints { get; set; }

        public ElementPaint(ToolsPaint TT, Color C, float LS)
        {
            typeTool = TT;
            lineSize = LS;
            color = C;
            countPoints = 1;
            fill = false;
            listPoints = new List<Point>();

            if (typeTool == ToolsPaint.polygon)
                elementClose = false;
            else
                elementClose = true;

            if (typeTool == ToolsPaint.eraser)
                color = Color.White;
        }

        public void PrintElementPaint(Graphics g)
        {
            if (listPoints.Count > 1)
            {
                Pen pen = new Pen(color, lineSize);
                g.SmoothingMode = SmoothingMode.HighQuality;

                int xMin = Math.Min(listPoints[0].X, listPoints[1].X);
                int yMin = Math.Min(listPoints[0].Y, listPoints[1].Y);
                int xMax = Math.Max(listPoints[0].X, listPoints[1].X);
                int yMax = Math.Max(listPoints[0].Y, listPoints[1].Y);

                if (fill == true && listPoints.Count > 3 && typeTool != ToolsPaint.polygon)
                    g.FillClosedCurve(new SolidBrush(color), listPoints.ToArray());
                else if (typeTool == ToolsPaint.pencil || typeTool == ToolsPaint.eraser)
                    g.DrawLines(pen, listPoints.ToArray());
                else if (typeTool == ToolsPaint.rectangle)
                {
                    if (fill == true)
                        g.FillRectangle(new SolidBrush(color), xMin, yMin, xMax - xMin, yMax - yMin);
                    else
                        g.DrawRectangle(pen, xMin, yMin, xMax - xMin, yMax - yMin);
                }
                else if (typeTool == ToolsPaint.ellipse)
                {
                    if (fill == true)
                        g.FillEllipse(new SolidBrush(color), xMin, yMin, xMax - xMin, yMax - yMin);
                    else
                        g.DrawEllipse(pen, xMin, yMin, xMax - xMin, yMax - yMin);
                }
                else if (typeTool == ToolsPaint.line)
                    g.DrawLine(pen, listPoints[0].X, listPoints[0].Y, listPoints[1].X, listPoints[1].Y);
                else if (typeTool == ToolsPaint.text)
                {
                    Font font = new Font("Tahoma", lineSize);
                    g.DrawString(text, font, new SolidBrush(color), new PointF(listPoints[0].X, listPoints[0].Y));
                }
                else if (typeTool == ToolsPaint.polygon)
                {
                    if (fill == true)
                        g.FillPolygon(new SolidBrush(color), listPoints.ToArray());
                    else
                        g.DrawLines(pen, listPoints.ToArray());
                }
                else if(typeTool == ToolsPaint.brush)
                {
                    HatchBrush myHatchBrush = new HatchBrush(hatchStyle, Color.White, color);
                    int ls = (int)lineSize / 2 + 1;
                    g.FillEllipse(myHatchBrush, new Rectangle(listPoints.Last().X - ls, listPoints.Last().Y - ls, (int)lineSize, (int)lineSize));
                }
            }
        }

        public void PointRemove()
        {
            if (listPoints.Count > 1 && listPoints.Count > countPoints)
                listPoints.RemoveAt(countPoints);
        }

        public void PrintResetBrush(Graphics g, Color c)
        {
            int ls = (int)lineSize / 2 + 1;
            HatchBrush myHatchBrush = new HatchBrush(hatchStyle, c, color);
            for (int i = listPoints.Count - 1; i >= 0; i--)
                g.FillEllipse(myHatchBrush, new Rectangle(listPoints[i].X - ls, listPoints[i].Y - ls, (int)lineSize, (int)lineSize));  
        }
    }
}
