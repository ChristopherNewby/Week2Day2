using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Eagle : Birds
    {
        #region variables;


        private bool doesFly = false;
        private bool isBald = true;


        #endregion

        public Eagle()
        {
            base.Tail = true;

        }

        #region Properties

        public bool flys
        {
            get
            {
                return doesFly;
            }
        }

        public bool bald
        {
            get
            {
                return isBald;
            }
        }
        #endregion
    }
}
