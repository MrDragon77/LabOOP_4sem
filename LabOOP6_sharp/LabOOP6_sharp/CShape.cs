using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP6_sharp
{
    public abstract class CShape
    {
        internal float x;
        internal float y;
        internal bool isSelected;
        internal Color color;

        public CShape() {

        }

        public abstract bool Move(float dx, float dy, float xBorder, float yBorder);
        public abstract void Draw(PaintEventArgs e);
        public abstract bool MouseInside(MouseEventArgs e);
        public void ChangeColor(Color newColor)
        {
            if (isSelected)
            {
                color = newColor;
            }
        }
        public abstract bool ChangeSize(bool sizeOption, float xBorder, float yBorder);
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
