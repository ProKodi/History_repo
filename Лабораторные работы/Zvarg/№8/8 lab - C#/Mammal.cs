using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_lab___C_
{
    
    class Mammal : Animal
    {
        public string food_type { get; set; }
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
            return "Млекопитающее...скорее всего, бегает (хотя, может и, например, плавать)...";
        }
        
    }
}
