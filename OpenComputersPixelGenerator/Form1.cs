using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenComputersPixelGenerator
{
    public partial class frmMain : Form
    {
        List<KeyValuePair<string, int>> orderedColors = new List<KeyValuePair<string, int>>();


        Color selectedColor = Color.White;


        List<ColorCounter> usedColors = new List<ColorCounter> { new ColorCounter(Color.White, 0), new ColorCounter(Color.Orange, 0), new ColorCounter(Color.Magenta, 0), new ColorCounter(Color.LightBlue, 0), new ColorCounter(Color.Yellow, 0), new ColorCounter(Color.Lime, 0), new ColorCounter(Color.Pink, 0), new ColorCounter(Color.Gray, 0),  new ColorCounter(Color.LightGray, 0), new ColorCounter(Color.Cyan, 0), new ColorCounter(Color.Purple, 0), new ColorCounter(Color.Blue, 0), new ColorCounter(Color.Brown, 0), new ColorCounter(Color.Green, 0), new ColorCounter(Color.Red, 0), new ColorCounter(Color.Black, 0) };

        Color[,] bgColors = new Color[16, 16];




        public class ColorCounter
        {
            public ColorCounter(Color c, int a)
            {
                color = c;
                amount = a;
            }

            public Color color { get; set; }
            public int amount { get; set; }

            public void incAmount()
            {
                amount = amount+1;
            }

            public void decAmount()
            {
                amount = amount - 1;
            }

            public override string ToString() => $"({color}, {amount})";
        }

        public ColorCounter getColorCounter(Color c)
        {
            foreach(ColorCounter CC in usedColors)
            {
                if(CC.color == c)
                {
                    return CC;
                }
            }

            return null;
        }
        public frmMain()
        {
            InitializeComponent();

            ColorCounter CC = getColorCounter(selectedColor);

            for (int i = 0; i < 16; i++)
            {

                for(int y = 0; y < 16; y++)
                {

                    
                    bgColors[i,y] = selectedColor;
                    CC.incAmount();
                }

            }

            updateColorAmounts();


            orderedColors.Add(new KeyValuePair<string, int>("White", 0));
            orderedColors.Add(new KeyValuePair<string, int>("Orange", 1));
            orderedColors.Add(new KeyValuePair<string, int>("Magenta", 2));
            orderedColors.Add(new KeyValuePair<string, int>("LightBlue", 3));
            orderedColors.Add(new KeyValuePair<string, int>("Yellow", 4));
            orderedColors.Add(new KeyValuePair<string, int>("Lime", 5));
            orderedColors.Add(new KeyValuePair<string, int>("Pink", 6));
            orderedColors.Add(new KeyValuePair<string, int>("Gray", 7));
            orderedColors.Add(new KeyValuePair<string, int>("LightGray", 8));
            orderedColors.Add(new KeyValuePair<string, int>("Cyan", 9));
            orderedColors.Add(new KeyValuePair<string, int>("Purple", 10));
            orderedColors.Add(new KeyValuePair<string, int>("Blue", 11));
            orderedColors.Add(new KeyValuePair<string, int>("Brown", 12));
            orderedColors.Add(new KeyValuePair<string, int>("Green", 13));
            orderedColors.Add(new KeyValuePair<string, int>("Red", 14));
            orderedColors.Add(new KeyValuePair<string, int>("Black", 15));


        }

        private int getColorIndex(Color c)
        {


            foreach(KeyValuePair<string,int> KVP in orderedColors)
            {
                if(KVP.Key == c.Name)
                {
                    return KVP.Value;
                }
            }

            return -1;
        }



        private void updateColorAmounts()
        {
            foreach (ColorCounter CC in usedColors)
            {
                string coloramount = "lblAmount" + CC.color.Name;

                int stacks = 0;

                if (CC.amount > 0)
                {
                    if (CC.amount < 64)
                    {
                        stacks = 1;
                    }
                    else
                    {
                        stacks = (int)Math.Ceiling((double)CC.amount / 64);
                    }
                }
                panel1.Controls[coloramount].Text = "" + CC.amount + "(" + stacks + ")";
            }
        }
        private void incrementColor(Color c)
        {
            bool found = false;




            foreach (ColorCounter CC in usedColors)
            {
                if (CC.color == c)
                {
                    CC.incAmount();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                ColorCounter colorC = new ColorCounter(c, 1);
                usedColors.Add(colorC);
            }


        }

        private void decrementColor(Color c)
        {
            bool found = false;




            foreach (ColorCounter CC in usedColors)
            {
                if (CC.color == c)
                {
                    CC.decAmount();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                ColorCounter colorC = new ColorCounter(c, 0);
                usedColors.Add(colorC);
            }

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

          //  bool sucess = loadImage(@"fireflower.png");
         //   if(!sucess) return;

            //for(int i = 0; i < usedColors.Count; i++)
            //{
            //    ColorCounter CC = usedColors[i];

            //    Label image = null;
            //    Label amount = null;

                
            //        foreach (Control control in flpColors.Controls[i].Controls)
            //        {
            //            if (control is Label)
            //            {
            //                Label lbl = (Label)control;
            //                if (lbl.Name.Equals("lblColor"+(i+1)))
            //                    image = lbl;
            //                if (lbl.Name.Equals("lblamount"+(i+1)))
            //                    amount = lbl;
            //            }
            //        }
                
            //    if(image == null || amount == null)
            //    {
            //        MessageBox.Show("There was an error.");
            //        return;
            //    }

            //    image.BackColor = CC.color;
            //    amount.Text = ""+CC.amount;
            //}

        }


        //private bool loadImage(string location)
        //{

        //    Bitmap myBitmap = new Bitmap(location);
        //    for (int x = 0; x < myBitmap.Width; x++)
        //    {
        //        for (int y = 0; y < myBitmap.Height; y++)
        //        {
        //            Color pixelColor = myBitmap.GetPixel(x, y);

        //           -

        //        }
        //    }

        //    if (usedColors.Count > 16)
        //    {
        //        MessageBox.Show("Too many colors found!");
        //        return false;
        //    }
        //    return true;
        //}
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DoubleBufferedTable1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (var b = new SolidBrush(bgColors[e.Column, e.Row]))
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }

            e.Graphics.DrawRectangle(new Pen(Color.Black), e.CellBounds);
        }



        Point? GetRowColIndex(TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return null;

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = tlp.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;

            return new Point(col, row);
        }

        private void DoubleBufferedTable1_Click(object sender, EventArgs e)
        {
            Point cellPos = (Point)GetRowColIndex(
        DoubleBufferedTable1,
        DoubleBufferedTable1.PointToClient(Cursor.Position));

            decrementColor(bgColors[cellPos.X, cellPos.Y]);
            bgColors[cellPos.X, cellPos.Y] = selectedColor;
            DoubleBufferedTable1.Refresh();

            incrementColor(bgColors[cellPos.X, cellPos.Y]);
            updateColorAmounts();
        }


        private void SelectColor_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.Name.Contains("White"))
                    selectedColor = Color.White;
                else if (clickedLabel.Name.Contains("Orange"))
                    selectedColor = Color.Orange;
                else if (clickedLabel.Name.Contains("Magenta"))
                    selectedColor = Color.Magenta;
                else if (clickedLabel.Name.Contains("LightBlue"))
                    selectedColor = Color.LightBlue;
                else if (clickedLabel.Name.Contains("Yellow"))
                    selectedColor = Color.Yellow;
                else if (clickedLabel.Name.Contains("Lime"))
                    selectedColor = Color.Lime;
                else if (clickedLabel.Name.Contains("Pink"))
                    selectedColor = Color.Pink;
                else if (clickedLabel.Name.Equals("lblColorGray"))
                    selectedColor = Color.Gray;
                else if (clickedLabel.Name.Contains("LightGray"))
                    selectedColor = Color.LightGray;
                else if (clickedLabel.Name.Contains("Cyan"))
                    selectedColor = Color.Cyan;
                else if (clickedLabel.Name.Contains("Purple"))
                    selectedColor = Color.Purple;
                else if (clickedLabel.Name.Contains("Blue"))
                    selectedColor = Color.Blue;
                else if (clickedLabel.Name.Contains("Brown"))
                    selectedColor = Color.Brown;
                else if (clickedLabel.Name.Contains("Green"))
                    selectedColor = Color.Green;
                else if (clickedLabel.Name.Contains("Red"))
                    selectedColor = Color.Red;
                else if (clickedLabel.Name.Contains("Black"))
                    selectedColor = Color.Black;

                lblSelectedColor.BackColor = selectedColor;

            }


            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtGeneration.Clear();
            string dec = "local coltab = {";
            for(int x = 0; x < 16; x++)
            {
                for(int y = 0; y < 16; y++)
                {
                    int colIndex = getColorIndex(bgColors[x, y]);

                    dec += "" + colIndex;

                    if (x == 15 && y == 15)
                        dec += "}";
                    else
                        dec += ",";
                }
            }

            txtGeneration.AppendText(dec);
            txtGeneration.AppendText(Environment.NewLine + Environment.NewLine + Properties.Resources.Template);

            Clipboard.SetText(txtGeneration.Text);
            MessageBox.Show("Code has been copied to clipboard, middle mouse click in a OpenComputers lua document to paste");
        }
    }
}
