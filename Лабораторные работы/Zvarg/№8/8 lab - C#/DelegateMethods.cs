using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _5_lab___C_
{
    class DelegateMethods
    {
        public static string GetFishInfo(Fish self)
        {
            if (self.is_it_freshwater)
            {
                return "Название: " + self.name + ", вид: " + self.type + ", местообитание: " + self.habitat + ". " + "Пресноводная " + self.ShowMovement() + "в пресных водоёмах";
            }
            else
            {
                return "Название: " + self.name + ", вид: " + self.type + ", местообитание: " + self.habitat + ". " + "Морская " + self.ShowMovement() + "в морях и океанах";
            }
        }
        public static string GetFishMovement()
            {
                return "рыба, соответственно, плавает ";
            }
    }
}
