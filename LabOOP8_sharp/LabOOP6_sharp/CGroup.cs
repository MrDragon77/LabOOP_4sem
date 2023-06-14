using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP8_sharp
{
    internal class CGroup : CShape
    {
        public MyList<CShape> elems = new MyList<CShape>();
        public CGroup()
        {
            isSelected = true;
        }
        public CGroup(CCircle origin)
        {
            isSelected = origin.isSelected;
        }

        public void AddElem(CShape shape)
        {
            elems.push_back(shape);
        }
        public CShape PopElem()
        {
            if(elems.size() > 0)
            {
                elems.to_end();
                CShape lastElem = elems.getData();
                elems.DeleteCurrent();
                return lastElem;
            }
            else
            {
                return null;
            }
        }

        public override bool Move(float dx, float dy, float xBorder, float yBorder)
        {
            if (isSelected)
            {
                bool canMove = CanMove(dx, dy, xBorder, yBorder);
                if (canMove)
                {
                    foreach(CShape i in elems)
                    {
                        i.ForceMove(dx, dy);
                    }
                    observable.Notify(dx, dy, xBorder, yBorder);
                }
                return canMove;
            }
            return false;
        }

        public override bool CanMove(float dx, float dy, float xBorder, float yBorder)
        {
            bool canMove = true;
            foreach (CShape i in elems)
            {
                if (!i.CanMove(dx, dy, xBorder, yBorder)) {
                    canMove = false;
                }
            }
            return canMove;
        }
        public override void ForceMove(float dx, float dy)
        {
            foreach (CShape i in elems)
            {
                i.ForceMove(dx, dy);
            }
        }

        public override void ChangeColor(Color newColor)
        {
            if (isSelected)
            {
                foreach(CShape i in elems)
                {
                    i.ChangeColor(newColor);
                }
            }
        }

        public override bool ChangeSize(float dsize, float xBorder, float yBorder)
        {
            if (isSelected)
            {
                bool canMove = CanChangeSize(dsize, xBorder, yBorder);
                if (canMove)
                {
                    foreach (CShape i in elems)
                    {
                        i.ForceChangeSize(dsize);
                    }
                }
                return canMove;
            }
            return false;
        }
        public override bool CanChangeSize(float dsize, float xBorder, float yBorder)
        {
            bool canChangeSize = true;
            foreach (CShape i in elems)
            {
                if (!i.CanChangeSize(dsize, xBorder, yBorder)) {
                    canChangeSize = false;
                }
            }
            return canChangeSize;
        }
        public override void ForceChangeSize(float dsize)
        {
            foreach (CShape i in elems)
            {
                i.ForceChangeSize(dsize);
            }
        }

        public override void Draw(PaintEventArgs e)
        {
            foreach (CShape i in elems)
            {
                i.Draw(e);
            }
        }

        public override bool MouseInside(MouseEventArgs e)
        {
            foreach(CShape i in elems)
            {
                if(i.MouseInside(e))
                {
                    return true;
                }
            }
            return false;
        }
        public override void Selected(bool selectOption)
        {
            isSelected = selectOption;
            foreach(CShape i in elems)
            {
                i.Selected(selectOption);
            }
        }

        public override bool Return_isSelected()
        {
            return isSelected;
        }

        public override float GetX()
        {
            if(elems.size() == 0)
            {
                return 0.0f;
            }
            float averageX = 0;
            foreach(CShape it in elems)
            {
                averageX += it.GetX();
            }
            averageX /= elems.size();
            return averageX;
        }
        public override float GetY()
        {
            if (elems.size() == 0)
            {
                return 0.0f;
            }
            float averageY = 0;
            foreach (CShape it in elems)
            {
                averageY += it.GetY();
            }
            averageY /= elems.size();
            return averageY;
        }

        public override void Save(StreamWriter file)
        {
            file.WriteLine("GR");
            file.WriteLine("size: " + elems.size());
            file.WriteLine("isSelected: " + isSelected.ToString());
            foreach (CShape i in elems)
            {
                i.Save(file);
            }
            file.WriteLine("\\GR");
        }
        public override void Load(StreamReader file, CFactory<CShape> factory)
        {
            if (file != null)
            {
                while (elems.size() > 0)
                {
                    elems.DeleteCurrent();
                }

                string[] sizeArgs = file.ReadLine().Split(' ');
                int numOfElems = Int32.Parse(sizeArgs[1]);
                string[] selectArgs = file.ReadLine().Split(' ');
                isSelected = Convert.ToBoolean(selectArgs[1]);
                for (int i = 0; i < numOfElems; ++i)
                {
                    CShape elem = factory.CreateObject(file.ReadLine());
                    if (elem == null)
                    {
                        return;
                    }
                    elem.Load(file, factory);
                    elems.push_back(elem);
                }
                file.ReadLine();
            }
        }
    }
}
