using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace KeyMacro
{
    class Item
    {
        public int num { get; set; }
        public string key { get; set; }
        public int delay { get; set; }
        public int repeat { get; set; }
        public Item(int num, string key, int delay, int repeat)
        {
            this.num = num;
            this.key = key;
            this.delay = delay;
            this.repeat = repeat;
        }
    }
}
