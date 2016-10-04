using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Aquatic : Animal
    {
        #region variables;

        private bool swims = true;
        private bool hasScales = true;
        #endregion

        public Aquatic()
        {    
            base.Tail = true;
        }

        #region Properties

        public bool doesSwim
        {
            get
            {
                return swims;
            }
        }

        public bool HasScales
        {
            get
            {
                return hasScales;
            }
        }
        #endregion
    }
}
