﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP7_sharp
{
    internal class CTriangle : СIndividualShape
    {
        private float a; //сторона треугольника (треугольник равносторонний)
        public CTriangle()
        {
            x = 0;
            y = 0;
            a = 0;
            isSelected = true;
            color = Color.Red;
        }
        public CTriangle(float x, float y, float a, Color color)
        {
            this.x = x;
            this.y = y;
            this.a = a;
            isSelected = true;
            this.color = color;
        }
        public CTriangle(CTriangle origin)
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
            if(newX + a / 2 < xBorder && newY + a / 3 < yBorder && newX - a / 2 > 0 && newY - (2 * a) / 3 > 0)
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
            if (x + newA / 2 < xBorder && y + newA / 3 < yBorder && x - newA / 2 > 0 && y - (2 * newA) / 3 > 0)
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
            PointF[] points = new PointF[3];
            points[0] = new PointF(x, y-((2*a)/3));
            points[1] = new PointF(x-(a/2), y+(a/3));
            points[2] = new PointF(x+(a/2), y+(a/3));
            e.Graphics.DrawPolygon(myPen, points);
            e.Graphics.FillPolygon(myBrush, points);
        }

        public override bool MouseInside(MouseEventArgs e)
        {
            float i1 = (x - e.X) * (a) - ((-a) / 2) * (y - (2 * a / 3) - e.Y);
            float i2 = (-a) * (y + (a/3) - e.Y);
            float i3 = (x + (a/2) - e.X) * (-a) - ((-a) / 2) * (y + (a / 3) - e.Y);
            if ((i1 >= 0 && i2 >= 0 && i3 >= 0) || (i1 <= 0 && i2 <= 0 && i3 <= 0))
            {
                return true;
            }
            return false;
        }

        public override void Save(StreamWriter file)
        {
            file.WriteLine("T");
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
