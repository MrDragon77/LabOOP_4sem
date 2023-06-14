using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP8_sharp
{
    public abstract class CFactory<T>
    {
        public abstract T CreateObject(string code);
        public abstract string GetObjectType();
    }
}
