using System;
using System.Collections.Generic;
using System.Text;

namespace animals
{
    public class Dragon : Italkable
    {
        private static readonly string name;
        private int age;
        public Dragon(int age, string name)
        {
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }
        public string talk() { return "It is your destiny, young Merlin"; }
        public void setAge(int age)
        {
            this.age = age;
        }
        public string GetName()
        {
            return name;
        }
    }
}
