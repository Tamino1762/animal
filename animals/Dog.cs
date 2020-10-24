using System;
using System.Collections.Generic;
using System.Text;

namespace animals
{
    public class Dog : Italkable
    {
        private static readonly string name;
        private bool friendly;

        public Dog (Boolean friendly, string name)
        {
            this.friendly = friendly;
        }
        public Boolean isFriendly()
        {
            return friendly;
        }
        public string talk() { return "Woof"; }

        public string GetName()
        {
            return Dog.name;
        }
    }
}
