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

            while(herd.dinos.Count > 0 && fleet.fleet.Count > 0)
            {

            }

        }


    }
}
