using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Battlefield
    {

        Fleet fleet;
        Herd herd;

        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
        }



        public void StartBattle()
        {

            // intro function
            // game details
            // engage robo/dinos
            // display winner'

            StartGame();
            GameDesc();

            while(herd.dinos.Count > 0 && fleet.robos.Count > 0)
            {
                AttackTurn(fleet.robos[0], herd.dinos[0]);
            }

            Winner();
        }

        public void StartGame()
        {
            Console.WriteLine("Welcome to Robots vs Dinosaurs!");
        }

        public void GameDesc()
        {
            ;
        }

        public void AttackTurn(Robot robos, Dinosaur dinos)
        {
            robos.Attack(dinos);
            if (dinos.health <= 0)
            {
                Console.WriteLine($"{dinos.type} has been killed.");
                herd.dinos.Remove(dinos);
            }
            dinos.Attack(robos);
            if(robos.health <= 0)
            {
                Console.WriteLine($"{robos.name} has been killed.");
                fleet.robos.Remove(robos);
            }
        }


        public void Winner()
        {
            if (herd.dinos.Count > 0)
            {
                Console.WriteLine("Dinosaurs win!");
            }
            else
            {
                Console.WriteLine("Robots win!");
            }
        }


    }
}
