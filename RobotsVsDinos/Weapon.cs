using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Weapon
    {
        public string type;
        public int attackPower = 50;

        public Weapon(string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;

        }

    }
}
