using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    class cDeriveAnthony : cBaseFonctions
    {
        public override void humanModifier()
        {
            name = "Anthony";
            Lastname = "Bourque";
            Age = 18;
            job = "Etudiant";
            base.humanModifier();
        }
    }
}
