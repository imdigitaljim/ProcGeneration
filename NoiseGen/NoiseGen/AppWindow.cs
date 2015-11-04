using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoiseGen
{
    public partial class AppWindow : Form
    {
        public MapNodes nodes;
        public Bitmap paintMap;
        public Graphics g;
        public SolidBrush BRSHwtr;
        public SolidBrush BRSHmtn;
        public SolidBrush BRSHbord;
        public SolidBrush BRSHstd;
        public SolidBrush BRSHstart;
        public SolidBrush BRSHend;
        public SolidBrush BRSHpath;
        public Rectangle startNode;
        public Rectangle endNode;
        public PathFind path;
        public Pen stdPen;
        public Pen selPen;
        public bool isSelectStart;
        public bool isSelectEnd;
        public AppWindow()
        {
            InitializeComponent();
            InitializeColors();
            GetSliderValue();
            isSelectEnd = false;
            isSelectStart = false;
        }
        public void InitializeColors()
        {
            stdPen = new Pen(Color.Black, 1);
            selPen = new Pen(Color.Black, 1);
            BRSHstart = new SolidBrush(Color.Red);
            BRSHpath = new SolidBrush(Color.Pink);
            BRSHend = new SolidBrush(Color.Green);
            BRSHwtr = new SolidBrush(Color.Blue);
            BRSHmtn = new SolidBrush(Color.Gray);
            BRSHbord = new SolidBrush(Color.Black);
            BRSHstd = new SolidBrush(AppWindow.DefaultBackColor);
        }

        private void Generate_Click(object sender, System.EventArgs e)
        {
            GenerateMap();
            BTNfinish.Visible = true;
            BTNstart.Visible = true;
        }

        public void GenerateMap()
        {
            MapBox.CreateGraphics().Clear(AppWindow.DefaultBackColor);
            int w = 0, h = 0;
            try
            {
                w = Convert.ToInt32(TXTWidth.Text);
                h = Convert.ToInt32(TXTHeight.Text);
            }
            catch
            {
                Console.WriteLine("Input string is not a sequence of digits or Overflow");
                w = 20;
                h = 20;
            }
            paintMap = new Bitmap(MapBox.Size.Width, MapBox.Size.Height);
            g = Graphics.FromImage(paintMap);
            nodes = new MapNodes(w + 2, h + 2, MapBox.Size.Height); // + 2 is borders
            g.DrawRectangles(stdPen, nodes.nodeRect);
            FillBorderNodes();
            GenerateNoise();
            MapBox.Image = paintMap;

        }
        private void GenerateNoise()
        {
            Random r = new Random();
            int seed = r.Next(10000);
            for (int i = 0; i < nodes.width; i++)
            {
                for (int j = 0; j < nodes.height; j++)
                {
                    int offset = i * nodes.height + j;
                    float simple = Simplex.Generate(i / 4.0f, j / 4.0f, seed);
                    if (simple > (Math.Abs(BARnoise.Value - 9) / 10.0f) + .3f && !nodes.nodeGrid[offset].isBorder)
                    {
                        g.FillRectangle(BRSHmtn, nodes.nodeRect[offset]);
                        nodes.nodeGrid[offset].isBlocking = true;
                    }
                    else if (simple > Math.Abs(BARnoise.Value - 9) / 10.0f && !nodes.nodeGrid[offset].isBorder)
                    {
                        g.FillRectangle(BRSHwtr, nodes.nodeRect[offset]);
                        nodes.nodeGrid[offset].isBlocking = true;
                    }
                }
            }

        }
        private bool isBorder(Rectangle r)
        {
            return nodes.isBorderRectangle(r);
        }
        private void MapBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                Rectangle clicked = nodes.GetSelectedNode(e.X, e.Y);
                if (!isBorder(clicked))
                {
                    if (isSelectStart)
                    {
                        nodes.GetSelectedNode(clicked).isStart = true;
                        g.DrawRectangle(selPen, clicked);
                        g.FillRectangle(BRSHstart, clicked);
                        isSelectStart = false;
                        startNode = clicked;
                        BTNstart.Visible = false;
                    }
                    else if (isSelectEnd)
                    {
                        nodes.GetSelectedNode(clicked).isEnd = true;
                        g.DrawRectangle(selPen, clicked);
                        g.FillRectangle(BRSHend, clicked);
                        isSelectEnd = false;
                        endNode = clicked;
                        BTNfinish.Visible = false;
                    }
                    else if (!nodes.isBlocking(clicked))
                    {
                        nodes.GetSelectedNode(clicked).isBlocking = true;
                        g.DrawRectangle(selPen, clicked);
                        g.FillRectangle(BRSHbord, clicked);
                    }
                    else if (nodes.isBlocking(clicked))
                    {
                        nodes.GetSelectedNode(clicked).isBlocking = false;
                        g.FillRectangle(BRSHstd, clicked);
                        g.DrawRectangle(stdPen, clicked);
                    }

                }

            }
            catch
            {
                Console.WriteLine("Ignore if clicked out of bounds or preinitialized");
            }
            MapBox.Image = paintMap;

        }
        private void FillBorderNodes()
        {
            for (int i = 0; i < nodes.height * nodes.width; i++)
            {
                if (nodes.nodeGrid[i].isBorder)
                {
                    g.FillRectangle(BRSHbord, nodes.nodeGrid[i].rect);
                }

            }
        }

        private void BarNoise_Scroll(object sender, EventArgs e)
        {
            GetSliderValue();
        }
        private void GetSliderValue()
        {
            LBLnoise.Text = "Noise: " + BARnoise.Value;
        }

        private void BTNstart_Click(object sender, EventArgs e)
        {
            isSelectStart = true; 
        }

        private void BTNfinish_Click(object sender, EventArgs e)
        {
            isSelectEnd = true;
        }

        private void BTNbfs_Click(object sender, EventArgs e)
        {
            path = new PathFind(nodes, startNode);
            List<MapNodes.Node> bfspath = path.FindBFSPath();
            for (int i = 0; i < bfspath.Count; i++)
            {
                g.FillRectangle(BRSHstart, nodes.nodeRect[bfspath[i].index]);
            }

                MapBox.Image = paintMap;
        }

    }
}
