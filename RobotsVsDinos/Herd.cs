using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Herd
    {
        public List<Dinosaur> dinos;

        public Herd()
        {
            Dinosaur tRex = new Dinosaur("T-Rex", 100);
            Dinosaur bronto = new Dinosaur("Brontosaurus", 75);
            Dinosaur raptor = new Dinosaur("Raptor", 30);

            dinos = new List<Dinosaur>();


            dinos.Add(tRex);
            dinos.Add(bronto);
            dinos.Add(raptor);
        }
    }
}
