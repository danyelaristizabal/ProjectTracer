using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracer.Models
{
    // TextEventArgs.cs
    public class BoolEvent : EventArgs
    {
        private bool myBool;

        public BoolEvent(bool _myBool)
        {
            this.myBool = _myBool;
        }
        public bool MyBool
        {
            get { return myBool; }
        }
    }
}
