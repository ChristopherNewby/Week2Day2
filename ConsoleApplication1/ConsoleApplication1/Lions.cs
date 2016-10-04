using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Lion : Cat
    {

        #region variables;


        private bool kingOfTheJungle;
        private bool hasMane;


        #endregion

        public Lion()
        {
            

        }

        #region Properties

        public bool King
        {
            get
            {
                return kingOfTheJungle;
            }
            set
            {
                kingOfTheJungle = value;
            }
        }

        public bool Mane
        {
            get
            {
                return hasMane;
            }
            set
            {
                hasMane = value;
            }
        }
        #endregion
    }
}
    
