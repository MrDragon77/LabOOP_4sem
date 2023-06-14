using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP8_sharp
{
    public class СObservable
    {
        public List<CShape> observers;

        public СObservable()
        {
            observers = new List<CShape>();
        }

        public void AddObserver(CShape observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(CShape observer)
        {
            observers.Remove(observer);
        }

        public void Notify(float dx, float dy, float xBorder, float yBorder)
        {
            foreach (CShape it in observers)
            {
                if (it.visited == false)
                {
                    it.visited = true;
                    it.Move(dx, dy, xBorder, yBorder);
                }
            }
        }

        public void DrawLines(float start_x, float start_y, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2.0f);
            pen.CustomStartCap = new AdjustableArrowCap(6, 6, true);
            foreach (CShape it in observers)
            {
                e.Graphics.DrawLine(pen, it.GetX(), it.GetY(), start_x, start_y);
            }
        }

        internal void Reset()
        {
            foreach (CShape shape in observers)
            {
                shape.visited = false;
            }
        }

        public void Clear()
        {
            observers.Clear();
        }
    }
}
