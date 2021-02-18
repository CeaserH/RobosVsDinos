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
        public Weapon weapon;


        public Robot(string name, string weapType, int weapPow)
        {
            this.name = name;
            this.health = 100;
            this.weapon = new Weapon(weapType, weapPow);
        }

        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.health -= weapon.attackPower;
            Console.WriteLine($"{name} attacks {dinosaur.type} with {weapon.type} for {weapon.attackPower} damage. {dinosaur.type}'s new heatlh is {dinosaur.health}.");
        }
    }
}
