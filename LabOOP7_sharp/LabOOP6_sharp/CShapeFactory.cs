using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP7_sharp
{
    public class CShapeFactory : CFactory<CShape>
    {
        public override CShape CreateObject(string code)
        {
            CShape shape = null;
            switch(code)
            {
                case "C":
                    shape = new CCircle();
                    break;
                case "S":
                    shape = new CSquare();
                    break;
                case "T":
                    shape = new CTriangle();
                    break;
                case "GR":
                    shape = new CGroup();
                    break;
            }
            return shape;
        }

        public override string GetObjectType()
        {
            return GetType().ToString().Split('.')[0];
        }
    }
}
