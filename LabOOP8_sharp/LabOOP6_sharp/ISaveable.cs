using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP8_sharp
{
    public interface ISaveable<T>
    {
        void Save(StreamWriter file);
        void Load(StreamReader file, CFactory<T> factory);
    }
}
