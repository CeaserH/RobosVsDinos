using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Dinosaur
    {

        public string type;
        public int health;
        public int energy;
        public int attackPower;

        public Dinosaur(string type, int attackPower)
        {
            this.type = type;
            this.health = 100;
            this.attackPower = attackPower;
        }

        public void Attack(Robot robot)
        {
            robot.health -= attackPower;
            Console.WriteLine($"{type} attacks {robot.name} for {attackPower} damage. {robot.name}'s new health is {robot.health}.");
        }
        
    }
}
