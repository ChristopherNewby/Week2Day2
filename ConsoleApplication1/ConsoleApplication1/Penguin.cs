using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Penguin : Birds
    {
        #region variables;


        private bool doesNotFly = true;
        private bool livesInCold = true;


        #endregion

        public Penguin()
        {
            base.Tail = false;

        }

        #region Properties

        public bool Flys
        {
            get
            {
                return doesNotFly;
            }
        }

        public bool weather
        {
            get
            {
                return livesInCold;
            }
        }
        #endregion
    }
}
