using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_lab___C_
{
    abstract class Animal
    {
        protected string name;
        protected string type;
        protected string habitat;
        public virtual string ShowInfo()
        {
            return "Название: " + name + ", вид: " + type + ", местообитание: " + habitat + ShowMovement();   
        }
        public abstract string ShowMovement();
    }
}
