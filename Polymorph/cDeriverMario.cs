using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    class cDeriverMario : cBaseFonctions
    {

        public override void humanModifier() {
            name = "Mario";
            Lastname = "Lacroix";
            Age = 39;
            job = "Prof";
            base.humanModifier();
        }


    }
}
