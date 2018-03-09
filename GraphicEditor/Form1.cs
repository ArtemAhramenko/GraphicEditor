using GraphicEditor.Shapes;
using lab1;
using lab2.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class MainForm : Form
    {

        public bool status;
        public int X1, Y1, X2, Y2;
        List<Point> points = new List<Point>();
        List<Figure> figures = new List<Figure>();
        List<Figure> deleteFigures = new List<Figure>();
        Graphics g;
        public Color paintColor = Color.Black;
        Color listColor = Color.Black;
        Pen pen;
        int tag;
        bool paint;
        Dictionary<int, Figure> figuresDict = new Dictionary<int, Figure>();

        public MainForm()
        {
            InitializeComponent();
            g = mainPane.CreateGraphics();
            pen = new Pen(paintColor, 1);
        }

        private void pictureBoxColor_Click(object sender, EventArgs e)
        {
            DialogResult dRes = colorDialog1.ShowDialog();
            if (dRes == DialogResult.OK)
            {
                paintColor = colorDialog1.Color;
                pictureBoxColor.BackColor = colorDialog1.Color;
            }
        }

        private void mainPane_MouseDown(object sender, MouseEventArgs e)
        {
            X1 = e.X;
            Y1 = e.Y;

            pointX.Text = "X = " + X1;
            pointY.Text = "Y = " + Y1;

            paint = true;
        }

        private void chooseObject()
        {
            figuresDict.Add(1, new Circle(new Point(X1, Y1), new Point(X2, Y2)));
            figuresDict.Add(2, new Square(new Point(X1, Y1), new Point(X2, Y2)));
            figuresDict.Add(3, new Rectangle(new Point(X1, Y1), new Point(X2, Y2)));
            figuresDict.Add(4, new Triangle(new Point(X1, Y1), new Point(X2, Y2)));
            figuresDict.Add(5, new Ellipse(new Point(X1, Y1), new Point(X2, Y2)));
            figuresDict.Add(6, new Line(new Point(X1, Y1), new Point(X2, Y2)));
            figuresDict.Add(7, new RightTriangle(new Point(X1, Y1), new Point(X2, Y2)));
        }

        private void pictureBoxUndo_Click(object sender, EventArgs e)
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

        private void pictureBoxRedo_Click(object sender, EventArgs e)
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

        private void mainPane_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            X2 = e.X;
            Y2 = e.Y;

            chooseObject();
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

        private void pictureBoxShape_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            Convert.ToInt32(pictureBox.Tag);
            tag = Convert.ToInt32(pictureBox.Tag);
        }

        private void mainPane_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                X2 = e.X;
                Y2 = e.Y;
            }
        }
    }
}