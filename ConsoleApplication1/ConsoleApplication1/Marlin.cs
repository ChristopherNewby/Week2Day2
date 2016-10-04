using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Marlin : Aquatic
    {
        #region variables;


        private bool hasSwordNose = true;
        private bool hasFins = true;


        #endregion

        public Marlin()
        {
            base.NumberLegs = 0;

        }

        #region Properties

        public bool Swordnose
        {
            get
            {
                return hasSwordNose;
            }
        }

        public bool Fins
        {
            get
            {
                return hasFins;
            }
        }
        #endregion
    }
}
