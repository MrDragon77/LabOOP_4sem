using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP7_sharp
{
    internal class CSquare : СIndividualShape
    {
        private float a; //сторона квадрата
        public CSquare()
        {
            x = 0;
            y = 0;
            a = 0;
            isSelected = true;
            color = Color.Red;
        }
        public CSquare(float x, float y, float a, Color color)
        {
            this.x = x;
            this.y = y;
            this.a = a;
            isSelected = true;
            this.color = color;
        }
        public CSquare(CSquare origin)
        {
            x = origin.x;
            y = origin.y;
            a = origin.a;
            isSelected = origin.isSelected;
            color = origin.color;
        }

        public override bool CanMove(float dx, float dy, float xBorder, float yBorder)
        {
            float newX = x + dx;
            float newY = y + dy;
            if(newX + a / 2 < xBorder && newY + a / 2 < yBorder && newX - a / 2 > 0 && newY - a / 2 > 0)
            {
                return true;
            }
            return false;
        }

        public override bool CanChangeSize(float dsize, float xBorder, float yBorder)
        {
            float newA = a + dsize;
            if (newA < 10.0f)
            {
                return false;
            }
            if (x + newA / 2 < xBorder && y + newA / 2 < yBorder && x - newA / 2 > 0 && y - newA / 2 > 0)
            {
                return true;
            }
            return false;
        }
        public override void ForceChangeSize(float dsize)
        {
            a += dsize;
        }

        public override void Draw(PaintEventArgs e)
        {
            Pen myPen;
            Brush myBrush;
            if (isSelected)
            {
                myPen = new Pen(Color.DarkBlue, 5);
                myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                myBrush = new SolidBrush(color);
            }
            else
            {
                myPen = new Pen(Color.Black, 5);
                myBrush = new SolidBrush(color);
            }
            e.Graphics.DrawRectangle(myPen, x - a / 2, y - a / 2, a, a);
            e.Graphics.FillRectangle(myBrush, x - a / 2, y - a / 2, a, a);
        }

        public override bool MouseInside(MouseEventArgs e)
        {
            if(e.X > x + a/2 || e.X < x - a / 2 || e.Y > y + a / 2 || e.Y < y - a / 2)
            {
                return false;
            }
            return true;
        }

        public override void Save(StreamWriter file)
        {
            file.WriteLine("S");
            base.Save(file);
            file.WriteLine("a: " + a.ToString());
        }

        public override void Load(StreamReader file, CFactory<CShape> factory)
        {
            if (file != null)
            {
                base.Load(file, factory);
                string[] args = file.ReadLine().Split(' ');
                a = Int32.Parse(args[1]);
            }
        }
    }
}
