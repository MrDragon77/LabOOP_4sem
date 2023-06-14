using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP7_sharp
{
    public abstract class CShape : ISaveable<CShape>
    {
        internal bool isSelected;

        public CShape() {  }

        public abstract bool Move(float dx, float dy, float xBorder, float yBorder);
        public abstract bool CanMove(float dx, float dy, float xBorder, float yBorder); //можно ли сдвинуться
        public abstract void ForceMove(float dx, float dy);
        public abstract void Draw(PaintEventArgs e);
        public abstract bool MouseInside(MouseEventArgs e);
        public abstract void ChangeColor(Color newColor);
        public abstract bool ChangeSize(float dsize, float xBorder, float yBorder);
        public abstract bool CanChangeSize(float dsize, float xBorder, float yBorder);
        public abstract void ForceChangeSize(float dsize);
        public abstract void Selected(bool selectOption);
        public abstract bool Return_isSelected();

        public abstract void Save(StreamWriter file);
        public abstract void Load(StreamReader file, CFactory<CShape> factory);
    }
}
