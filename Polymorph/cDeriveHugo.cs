using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    class cDeriveHugo : cBaseFonctions
    {

        public override void humanModifier()
        {
            name = "Hugo";
            Lastname = "Labelle";
            Age = 44;
            job = "Grippé";
            base.humanModifier();
        }
    }
}
