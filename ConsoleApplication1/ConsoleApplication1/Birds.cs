using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Birds : Animal
    {

        #region variables;


        private bool hasBeak = true;
        private bool laysEggs;


        #endregion

        public Birds()
        {
            base.NumberLegs = 2;
        }

        #region Properties

        public bool Beak
        {
            get
            {
                return hasBeak;
            }
        }

        public bool Eggs
        {
            get
            {
                return laysEggs;
            }
            set
            {
                laysEggs = value;

            }
            #endregion
        }
    }
}
 