using System;

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
