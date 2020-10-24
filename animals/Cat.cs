using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Transactions;
using Unity;

namespace animals
{
    public class Cat : Italkable
    {

        private int mousesKilled;
        private static readonly string name;

        public Cat(int mousesKilled, string v)
        {
            this.mousesKilled = mousesKilled;
        }
        public int GetMousesKilled() { return mousesKilled; }
        public string talk() { return "Meow"; }

        public string GetName()
        {
            return Cat.name;
        }
    }
}
