using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    class cPoule : cEggs
    {
        //public override void Information(string _TypeAnimal, string _TypePoil, string _Deplacement, string _Incubation, string _Nourriture, string _Famille)
        public override void Information()
        {
            TypeAnimal = "Poussin";
            //base.Information(_TypeAnimal, _TypePoil, _Deplacement, _Incubation, _Nourriture, _Famille);
            base.Information();
        }
    }
}
