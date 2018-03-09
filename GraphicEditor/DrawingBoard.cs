using GraphicEditor.Shapes;
using lab2.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lab2
{
    public partial class MainForm : Form
    {
        int x1, y1, x2, y2, tag;
        bool paint;

        List<Point> points = new List<Point>();
        List<Figure> figures = new List<Figure>();
        List<Figure> deleteFigures = new List<Figure>();
        Dictionary<int, Figure> figuresDict = new Dictionary<int, Figure>();

        Color paintColor = Color.Black;
        Color listColor = Color.Black;
        Graphics g;
        
        public MainForm()
        {
            InitializeComponent();
            g = mainPane.CreateGraphics();
        }

        private void PictureBoxColor_Click(object sender, EventArgs e)
        {
            DialogResult dRes = colorDialog1.ShowDialog();
            if (dRes == DialogResult.OK)
            {
                paintColor = colorDialog1.Color;
                pictureBoxColor.BackColor = colorDialog1.Color;
            }
        }

        private void MainPane_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            pointX.Text = "X = " + x1;
            pointY.Text = "Y = " + y1;
            paint = true;
        }

        private void ChooseObject()
        {
            figuresDict.Add(1, new Circle(new Pen(paintColor, 3), new Point(x1, y1), new Point(x2, y2)));
            figuresDict.Add(2, new Square(new Pen(paintColor, 3), new Point(x1, y1), new Point(x2, y2)));
            figuresDict.Add(3, new Rectangle(new Pen(paintColor, 3), new Point(x1, y1), new Point(x2, y2)));
            figuresDict.Add(4, new Triangle(new Pen(paintColor, 3), new Point(x1, y1), new Point(x2, y2)));
            figuresDict.Add(5, new Ellipse(new Pen(paintColor, 3), new Point(x1, y1), new Point(x2, y2)));
            figuresDict.Add(6, new Line(new Pen(paintColor, 3), new Point(x1, y1), new Point(x2, y2)));
            figuresDict.Add(7, new RightTriangle(new Pen(paintColor, 3), new Point(x1, y1), new Point(x2, y2)));
        }

        private void PictureBoxUndo_Click(object sender, EventArgs e)
        {
            if (figures.Count != 0)
            {
                deleteFigures.Add(figures[figures.Count - 1]);
                figures.RemoveAt(figures.Count - 1);
                mainPane.Controls.Clear();
                mainPane.Invalidate();
                mainPane.Update();
                foreach (Figure figure in figures)
                {
                    figure.Draw(g);
                }
            }
        }

        private void mainPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBoxRedo_Click(object sender, EventArgs e)
        {
            if (deleteFigures.Count != 0)
            {
                figures.Add(deleteFigures[deleteFigures.Count - 1]);
                deleteFigures.RemoveAt(deleteFigures.Count - 1);
                mainPane.Controls.Clear();
                mainPane.Invalidate();
                mainPane.Update();
                foreach (Figure figure in figures)
                {
                    figure.Draw(g);
                }
            }
        }

        private void MainPane_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            x2 = e.X;
            y2 = e.Y;
            ChooseObject();
            try
            {
                figures.Add(figuresDict[tag]);
                foreach (Figure figure in figures)
                {
                    figure.Draw(g);
                }
            }
            catch (KeyNotFoundException) { }
            figuresDict.Clear();
        }

        private void PictureBoxShape_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            Convert.ToInt32(pictureBox.Tag);
            tag = Convert.ToInt32(pictureBox.Tag);
        }

        private void MainPane_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                x2 = e.X;
                y2 = e.Y;
            }
        }
    }
}