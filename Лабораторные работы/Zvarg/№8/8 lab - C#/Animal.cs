using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_lab___C_
{
    abstract class Animal
    {
        public string name { get; set; }
        public string type { get; set; }
        public string habitat { get; set; }
        public virtual string ShowInfo()
        {
            return "Название: " + name + ", вид: " + type + ", местообитание: " + habitat + ShowMovement();   
        }
        public abstract string ShowMovement();
    }
}
