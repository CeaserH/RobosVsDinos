using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Fleet
    {

        public List<Robot> robos;
        public Fleet()
        {

            robos = new List<Robot>();

            Robot A1 = new Robot("A001", "Laser", 20);
            Robot A2 = new Robot("A002", "Bazooka", 60);
            Robot A3 = new Robot("A003", "Laser", 20);

            robos.Add(A1);
            robos.Add(A2);
            robos.Add(A3);



        }


    }
}
