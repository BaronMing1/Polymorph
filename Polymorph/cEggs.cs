using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
   abstract  class cEggs
    {
        protected string TypeAnimal = "";
        protected string TypePoil = "";
        protected string deplacement = "";
        protected string incubation = "";
        protected string nourriture = "";
        protected string famille = "";
        protected string phrase = "";

        public string Phrase
        {
            get { return $"Type:{TypeAnimal} poil: {TypePoil} , déplacement: {deplacement} , Incubation: {incubation} , bouffe: {nourriture} de la famille {famille}"; }
        }

        //public virtual void Information(string _TypeAnimal, string _TypePoil, string _Deplacement, string _Incubation, string _Nourriture, string _Famille) {
        public virtual void Information()
        {
            //TypeAnimal = _TypeAnimal;
            //TypePoil = _TypePoil;
            //deplacement = _Deplacement;
            //incubation = _Incubation;
            //nourriture = _Nourriture;
            //famille = _Famille;
        }
    }
}
