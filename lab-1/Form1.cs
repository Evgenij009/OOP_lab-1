using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Form1 : Form
    {
        Graphics graphic;
        Point startPoint;
        Point finishPoint;
        public int thickness = 1;
        public Color color = Color.Black;
        int tag = 3;
        Dictionary<int, Shape> shapesDictionary = new Dictionary<int, Shape>();
        List<Shape> demo = new List<Shape>();
        List<Shape> shapes = new List<Shape>();
        List<Shape> deletedShapes = new List<Shape>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClearDrawingBoard()
        {
            pbDrawingBoard.Controls.Clear();
            pbDrawingBoard.Invalidate();
            pbDrawingBoard.Update();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDrawingBoard();
            shapes.Clear();
            deletedShapes.Clear();
        }

        private void pbDrawingBoard_Click(object sender, EventArgs e)
        {

        }

        private void pbDrawingBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
