using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_lab___C_
{
    class Fish : Animal, MainInterface
    {
        public bool is_it_freshwater;
        public Fish()
        {
            this.is_it_freshwater = false;
            this.name = "Неизвестно";
            this.habitat = "Неизвестно";
            this.type = "Неизвестно";
        }
        public Fish(string name, string habitat, string type, bool is_it_freshwater)
        {
            this.name = name;
            this.habitat = habitat;
            this.type = type;
            if (is_it_freshwater == true) this.is_it_freshwater = true;
            else this.is_it_freshwater = false;
        }
        public Fish(Fish fish)
        {
            this.name = fish.name;
            this.type = fish.type;
            this.habitat = fish.habitat;
            this.is_it_freshwater = fish.is_it_freshwater;
        }
        public override string ShowInfo()
        {
            if (is_it_freshwater)
            {
                return "Название: " + name + ", вид: " + type + ", местообитание: " + habitat + ". " + "Пресноводная " + ShowMovement() + "в пресных водоёмах";
            }
            else
            {
                return "Название: " + name + ", вид: " + type + ", местообитание: " + habitat + ". " + "Морская " + ShowMovement() + "в морях и океанах";
            }
        }
        public override string ShowMovement()
        {
            return "рыба, соответственно, плавает ";
        }
        public override object Clone()
        {
            return new Fish(this);
        }
        public static bool operator ==(Fish fish1, Fish fish2)
        {
            return fish1.name == fish2.name;
        }
        public static bool operator !=(Fish fish1, Fish fish2)
        {
            return !(fish1.name == fish2.name);
        }
        public override int CompareTo(object? o)
        {
            if (o is Fish fish) return name.CompareTo(fish.name);
            else return -2;
        }
    }
}
