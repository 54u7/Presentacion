using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_app
{
    public partial class formPaint : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen eraser = new Pen(Color.White, 10);
        int index;
        int x, y, sx, sy, cx, cy;
        
        Color newColor;
        ColorDialog cd = new ColorDialog();

        public formPaint()
        {
            InitializeComponent();
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            index = 5;
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
                    index = 1;
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            float px = 1f * pb.Width / pb.Width;
            float py = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));
        }

        private void Validate(Bitmap bm, Stack<Point>sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }

        public void fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_Color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_Color == new_clr)
            {
                return;
            }
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if(pt.X > 0 && pt.Y > 0 && pt.X < bm.Width && pt.Y < bm.Height - 1)
                {
                    Validate(bm, pixel, pt.X - 1, pt.Y, old_Color, new_clr);
                    Validate(bm, pixel, pt.X, pt.Y - 1, old_Color, new_clr);
                    Validate(bm, pixel, pt.X + 1, pt.Y, old_Color, new_clr);
                    Validate(bm, pixel, pt.X, pt.Y + 1, old_Color, new_clr);
                }
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 6)
            {
                Point point = set_point(pic, e.Location);
                fill(bm, point.X, point.Y, newColor);
            }
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            newColor = cd.Color;
            pic.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cx = e.X;
            cy = e.Y;
        }

        

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2) 
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;
        }

        

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sx = x - cx;
            sy = y - cy;
            if (index == 3)
            {
                g.DrawEllipse(p, cx, cy, sx, sy);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cx, cy, sx, sy);
            }
            if (index == 5)
            {
                g.DrawLine(p, cx, cy, x, y);
            }
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

         private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cx, cy, sx, sy);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cx, cy, sx, sy);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cx, cy, x, y);
                }
            }
        }
    }
}
