using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP6_sharp
{
    internal class CCircle : CShape
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
        public CCircle(float x, float y, float r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            isSelected = true;
            color = Color.Red;
        }
        public CCircle(CCircle origin)
        {
            x = origin.x;
            y = origin.y;
            r = origin.r;
            isSelected = origin.isSelected;
            color = origin.color;
        }

        public override bool Move(float dx, float dy, float xBorder, float yBorder)
        {
            if (isSelected)
            {
                float newX = x + dx;
                float newY = y + dy;

                if (newX + r/2 < xBorder && newY + r/2 < yBorder && newX - r/2 > 0 && newY - r/2 > 0)
                {
                    x = newX;
                    y = newY;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public override bool ChangeSize(bool sizeOption, float xBorder, float yBorder)
        {
            if(isSelected)
            {
                if(sizeOption)
                {
                    float newR = r + 5.0f;
                    if (x + newR /2 < xBorder && y + newR/2 < yBorder && x - newR/2 > 0 && y - newR/2 > 0)
                    {
                        r = newR;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    float newR = r - 5.0f;
                    if(newR < 10.0f)
                    {
                        return false;
                    }
                    else
                    {
                        r = newR;
                    }
                }
            }
            return false;
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
    }
}
