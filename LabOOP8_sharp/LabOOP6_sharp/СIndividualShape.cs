using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP8_sharp
{
    public abstract class СIndividualShape : CShape
    {
        internal Color color;

        public override bool Move(float dx, float dy, float xBorder, float yBorder)
        {
            if (CanMove(dx, dy, xBorder, yBorder))
            {
                ForceMove(dx, dy);
                visited = true;
                observable.Notify(dx, dy, xBorder, yBorder);
                return true;
            }
            else
            {
                return false;
            }
        }

        //public abstract bool CanMove(float dx, float dy, float xBorder, float yBorder);

        public override void ForceMove(float dx, float dy)
        {
            x += dx;
            y += dy;
        }

        public override void ChangeColor(Color newColor)
        {
            color = newColor;
        }

        public override bool ChangeSize(float dsize, float xBorder, float yBorder)
        {
            if (CanChangeSize(dsize, xBorder, yBorder))
            {
                ForceChangeSize(dsize);
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Selected(bool selectOption)
        {
            isSelected = selectOption;
        }

        public override bool Return_isSelected()
        {
            return isSelected;
        }

        public override float GetX()
        {
            return x;
        }
        public override float GetY()
        {
            return y;
        }

        public override void Save(StreamWriter file)
        {
            file.WriteLine("Coords: " + x.ToString() + " " + y.ToString() + " isSelected: " + isSelected.ToString() + " Color: "
                + color.R.ToString() + " " + color.G.ToString() + " " + color.B.ToString());
        }

        public override void Load(StreamReader file, CFactory<CShape> factory)
        {
            if(file != null)
            {
                string[] args = file.ReadLine().Split(' ');
                x = Int32.Parse(args[1]);
                y = Int32.Parse(args[2]);
                isSelected = Convert.ToBoolean(args[4]);
                color = Color.FromArgb(255, Int32.Parse(args[6]), Int32.Parse(args[7]), Int32.Parse(args[8]));
            }
        }
    }
}
