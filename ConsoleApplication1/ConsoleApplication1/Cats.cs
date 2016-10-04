using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Cat : Animal
    {
        #region variables;


        private bool hasFur = true;
        private bool landsOnAllFours = true;


        #endregion

        public Cat()
        {
            base.NumberLegs = 4;
            base.Tail = true;

        }

        #region Properties

        public bool Fur
        {
            get
            {
                return hasFur;
            }
        }

        public bool allFours
        {
            get
            {
                return landsOnAllFours;
            }
        }
        #endregion
    }
}
