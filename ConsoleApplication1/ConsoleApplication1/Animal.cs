using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Animal : Program
    {
        #region Variables

        string name;
        int numLegs;
        bool hasTail;

        #endregion 
        public Animal()
        {
        }

        #region Properties

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }



        public bool Tail
        {
            get
            {
                return hasTail;
            }
            set
            {
                hasTail = value;
            }
        }

        public int NumberLegs
        {
            get
            {
                return numLegs;
            }

            set
            {
                numLegs = value;
            }
        }
        #endregion
    }
}
