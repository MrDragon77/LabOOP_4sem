using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP8_sharp
{
    internal class CCircle : СIndividualShape
    {
        private float r;
        public CCircle()
        {
            x = 0;
            y = 0;
            r = 0;
            isSelected = true;
            color = Color.Red;
        }
        public CCircle(float x, float y, float r, Color color)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            isSelected = true;
            this.color = color;
        }
        public CCircle(CCircle origin)
        {
            x = origin.x;
            y = origin.y;
            r = origin.r;
            isSelected = origin.isSelected;
            color = origin.color;
        }

        public override bool CanMove(float dx, float dy, float xBorder, float yBorder)
        {
            float newX = x + dx;
            float newY = y + dy;
            if (newX + r / 2 < xBorder && newY + r / 2 < yBorder && newX - r / 2 > 0 && newY - r / 2 > 0)
            {
                return true;
            }
            return false;
        }
        
        public override bool CanChangeSize(float dsize, float xBorder, float yBorder)
        {
            float newR = r + dsize;
            if (newR < 10.0f)
            {
                return false;
            }
            if (x + newR / 2 < xBorder && y + newR / 2 < yBorder && x - newR / 2 > 0 && y - newR / 2 > 0)
            {
                return true;
            }
              return false;
        }
        public override void ForceChangeSize(float dsize)
        {
            r += dsize;
        }

        public override void Draw(PaintEventArgs e)
        {
            Pen myPen;
            Brush myBrush = new SolidBrush(color);
            if (isSelected)
            {
                myPen = new Pen(Color.DarkBlue, 5);
                myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            else
            {
                myPen = new Pen(Color.Black, 5);
            }
            //RectangleF rect = new RectangleF(0.0F, 0.0F, 200.0F, 100.0F);
            e.Graphics.DrawEllipse(myPen, x - r/2, y - r/2, r, r);
            e.Graphics.FillEllipse(myBrush, x - r/2, y - r/2, r, r);
        }

        public override bool MouseInside(MouseEventArgs e)
        {
            if((e.X - x) * (e.X - x) + (e.Y - y) * (e.Y - y) > r/2 * r/2)
            {
                return false;
            }
            return true;
        }

        public override void Save(StreamWriter file)
        {
            file.WriteLine("C");
            base.Save(file);
            file.WriteLine("r: " + r.ToString());
        }

        public override void Load(StreamReader file, CFactory<CShape> factory)
        {
            if(file != null)
            {
                base.Load(file, factory);
                string[] args = file.ReadLine().Split(' ');
                r = Int32.Parse(args[1]);
            }
        }
    }
}
