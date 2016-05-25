using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smil
{
    class ComboboxItem
    {
        public string Text { get; set; }
        public returnObj Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
