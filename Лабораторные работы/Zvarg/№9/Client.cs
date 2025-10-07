using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _9_lab___C_
{
    class Client
    {
        public int age { get; set; }
        private string name;
        private string surname;
        private string trait;
        public string key { get; }
        public Client(int age, string name, string surname, string trait, string key) 
        {
            this.age = age;
            this.name = name; 
            this.surname = surname;
            this.trait = trait;
            this.key = key;
        }
        public string show_info()
        {
            return $"Имя: {name}, фамилия: {surname}, возраст: {age}, особая черта {trait}, ключ: {key}";
        }
    }
}
