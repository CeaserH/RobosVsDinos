using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Fleet
    {

        public List<Robot> fleet;

        public Fleet()
        {

            Robot A1 = new Robot("A001", "Laser", 20);
            Robot A2 = new Robot("A002", "Laser", 20);
            Robot A3 = new Robot("A003", "Laser", 20);

            fleet.Add(A1);
            fleet.Add(A2);
            fleet.Add(A3);



        }


    }
}
