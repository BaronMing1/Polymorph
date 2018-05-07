using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    class cBaseFonctions
    {

        public string phrase = "Je n suis pas overridé encore";

        protected string name = "";
        protected string Lastname = "";
        protected int Age = 0;
        protected string job = "";


        public virtual void humanModifier() {
            phrase = $"{name} {Lastname} {Age} {Environment.NewLine} {job}";

        }


    }
}
