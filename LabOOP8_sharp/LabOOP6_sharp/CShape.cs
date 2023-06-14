using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP8_sharp
{
    public abstract class CShape : ISaveable<CShape>
    {
        internal float x;
        internal float y;
        internal bool isSelected;
        public bool visited = false;
        internal СObservable observable;

        public CShape() {
            observable = new СObservable();
        }
        

        public abstract bool Move(float dx, float dy, float xBorder, float yBorder);
        public abstract bool CanMove(float dx, float dy, float xBorder, float yBorder); //можно ли сдвинуться
        public abstract void ForceMove(float dx, float dy);
        public abstract void Draw(PaintEventArgs e);
        public virtual void DrawArrows(PaintEventArgs e)
        {
            observable.DrawLines(GetX(), GetY(), e);
            observable.Reset();
        }
        public abstract bool MouseInside(MouseEventArgs e);
        public abstract void ChangeColor(Color newColor);
        public abstract bool ChangeSize(float dsize, float xBorder, float yBorder);
        public abstract bool CanChangeSize(float dsize, float xBorder, float yBorder);
        public abstract void ForceChangeSize(float dsize);
        public abstract void Selected(bool selectOption);
        public abstract bool Return_isSelected();
        public abstract float GetX();
        public abstract float GetY();

        public abstract void Save(StreamWriter file);
        public abstract void Load(StreamReader file, CFactory<CShape> factory);
    }
}
