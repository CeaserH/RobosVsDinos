using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Robot
    {

        public string name;
        public int health;
        public int power;
        // add weapon
        public double attackPower;


        public Robot(string name, int health, int power, double attackPower)
        {
            this.name = name;
            this.health = health;
            this.power = power;
            this.attackPower = attackPower;
        }
    }
}
