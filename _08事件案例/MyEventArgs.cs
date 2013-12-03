using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08事件案例
{
    public class MyEventArgs : EventArgs
    {
        public MyEventArgs()
        {
            this.Flag = false;
        }
        public bool Flag { get; set; }
        public string UserName { get; set; }
        public string Pwd { get; set; }
    }
}
