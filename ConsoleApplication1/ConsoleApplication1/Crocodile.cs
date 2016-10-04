using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Crocodile : Aquatic
    {
        #region variables;


        private bool goesOnLand;
        private bool isGreen = true;


        #endregion

        public Crocodile()
        {
            base.NumberLegs = 4;

        }

        #region Properties

        public bool Land
        {
            get
            {
                return goesOnLand;
            }
            set
            {
                goesOnLand = value;
            }
        }

        public bool Green
        {
            get
            {
                return isGreen;
            }
        }
        #endregion
    }
}
