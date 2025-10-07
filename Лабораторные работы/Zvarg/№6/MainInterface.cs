using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _6_lab___C_
{
    interface MainInterface : ICloneable, IComparable
    {
        public string ShowMovement();
        public string ShowInfo();

    }
}
