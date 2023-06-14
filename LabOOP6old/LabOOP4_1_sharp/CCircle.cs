using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP4_1_sharp
{
    internal class CCircle
    {
        private float x;
        private float y;
        private float r;
        private bool isSelected;
        public CCircle()
        {
            x = 0;
            y = 0;
            r = 0;
            isSelected = true;
        }
        public CCircle(float x, float y, float r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            isSelected = true;
        }
        public CCircle(CCircle origin)
        {
            x = origin.x;
            y = origin.y;
            r = origin.r;
            isSelected = origin.isSelected;
        }
        
        public void Draw(PaintEventArgs e)
        {
            Pen myPen;
            Brush myBrush;
            if (isSelected)
            {
                myPen = new Pen(Color.DarkBlue, 10);
                myBrush = new SolidBrush(Color.DarkRed);
            }
            else
            {
                myPen = new Pen(Color.Black, 10);
                myBrush = new SolidBrush(Color.Red);
            }
            //RectangleF rect = new RectangleF(0.0F, 0.0F, 200.0F, 100.0F);
            e.Graphics.DrawEllipse(myPen, x - r/2, y - r/2, r, r);
            e.Graphics.FillEllipse(myBrush, x - r/2, y - r/2, r, r);
        }

        public bool MouseInside(MouseEventArgs e)
        {
            if((e.X - x) * (e.X - x) + (e.Y - y) * (e.Y - y) > r/2 * r/2)
            {
                return false;
            }
            return true;
        }
        public void Selected(bool selectOption)
        {
            isSelected = selectOption;
        }

        public bool Return_isSelected()
        {
            return isSelected;
        }
    }
}
