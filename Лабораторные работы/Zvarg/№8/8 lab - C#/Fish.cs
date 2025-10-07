using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _5_lab___C_
{
    class Fish: Animal
    {
        public delegate string FishDelegate(Fish self);

        public event FishDelegate get_info_event = (Fish self) => { return self.ShowInfo(); };

        public event FishDelegate Inform_event
        {
            add { this.get_info_event = value; }
            remove { this.get_info_event = (Fish self) => { return self.ShowInfo(); }; }
        }

        public string get_inform_through_event()
        {
            return this.get_info_event(this);
        }
        
        public bool is_it_freshwater { get; set; }
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
    }
}
