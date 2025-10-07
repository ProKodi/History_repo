using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_lab___C_
{
    class Bird: Animal, MainInterface
    {
        bool is_it_poultry;
        bool is_it_migratory;
        public Bird()
        {
            this.is_it_poultry = false;
            this.is_it_migratory = false;
            this.name = "Неизвестно";
            this.habitat = "Неизвестно";
            this.type = "Неизвестно";
        }
        public Bird(string name, string habitat, string type, bool is_it_poultry, bool is_it_migratory)
        {
            this.name = name;
            this.habitat = habitat;
            this.type = type;
            if (is_it_poultry == true)
            {
                this.is_it_poultry = true;
                this.is_it_migratory = false;
            }
            else
            {
                if (is_it_migratory == true)
                {
                    this.is_it_poultry = false;
                    this.is_it_migratory = true;
                }
                else
                {
                    this.is_it_poultry = false;
                    this.is_it_migratory = false;
                }
            }
        }
        public override string ShowInfo()
        {
            if (is_it_poultry)
            {
                return "Название: " + name + ", вид: " + type + ", местообитание: " + habitat + ". " + "Домашняя." + ShowMovement();
            }
            else
            {
                if (is_it_migratory)
                {
                    return "Название: " + name + ", вид: " + type + ", местообитание: " + habitat + ". " + "Дикая. Перелётная." + ShowMovement();
                }
                else
                {
                    return "Название: " + name + ", вид: " + type + ", местообитание: " + habitat + ". " + "Дикая. Неперелётная." + ShowMovement();
                }
            }
        }
        public override string ShowMovement()
        {
            return "Птица летает.";
        }
        public override object Clone()
        {
            return MemberwiseClone();
        }
        public override int CompareTo(object? o)
        {
            if (o is Bird bird) return name.CompareTo(bird.name);
            else return -2;
        }
        public static bool operator ==(Bird bird1, Bird bird2)
        {
            return bird1.name == bird2.name;
        }
        public static bool operator !=(Bird bird1, Bird bird2)
        {
            return !(bird1.name == bird2.name);
        }
    }
}

