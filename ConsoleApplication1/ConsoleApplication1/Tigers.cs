using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Tiger : Cat
    {
        #region variables;


        private bool hasStripes = true;
        private bool sleepStandingUp;


        #endregion

        public Tiger()
        {


        }

        #region Properties

        public bool Stripes
        {
            get
            {
                return hasStripes;
            }
        }

        public bool Sleep
        {
            get
            {
                return sleepStandingUp;
            }
            set
            {
                sleepStandingUp = value;
            }
        }
    }
    #endregion

}

