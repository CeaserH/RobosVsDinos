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

            dinos = new List<Dinosaur>();

            Dinosaur tRex = new Dinosaur("T-Rex", 50);
            Dinosaur bronto = new Dinosaur("Brontosaurus", 45);
            Dinosaur raptor = new Dinosaur("Raptor", 30);

            dinos.Add(tRex);
            dinos.Add(bronto);
            dinos.Add(raptor);
        }
    }
}
