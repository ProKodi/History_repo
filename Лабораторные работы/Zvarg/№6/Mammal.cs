using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_lab___C_
{
    class Mammal : Animal
    {
        string food_type;
        public Mammal()
        {
            this.food_type = "Неизвестно";
            this.name = "Неизвестно";
            this.habitat = "Неизвестно";
            this.type = "Неизвестно";
        }
        public Mammal(string name, string habitat, string type, byte food_type_designation)
        {
            this.name = name;
            this.habitat = habitat;
            this.type = type;
            if (food_type_designation == 0) this.food_type = "Травоядное";
            if (food_type_designation == 1) this.food_type = "Хищник";
            if (food_type_designation == 2) this.food_type = "Всеядное";
        }
        public override string ShowInfo()
        {
            return "Название: " + name + ", вид: " + type + ", местообитание: " + habitat + ". " + food_type + "." + ShowMovement();
        }
        public override string ShowMovement()
        {
            return "Млекопитающее...допустим, бегает...";
        }
        public override object Clone()
        {
            return MemberwiseClone();
        }
        public override int CompareTo(object? o)
        {
            if (o is Mammal mammal) return name.CompareTo(mammal.name);
            else return -2;
        }
        public static bool operator ==(Mammal mammal1, Mammal mammal2)
        {
            return mammal1.name == mammal2.name;
        }
        public static bool operator !=(Mammal mammal1, Mammal mammal2)
        {
            return !(mammal1.name == mammal2.name);
        }
    }
}

