using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smil
{
    class returnObjEngine
    {


        public returnObjEngine pointer { get; set; }
        public returnObjEngine before { get; set; }
        public returnObjEngine next { get; set; }
        public dynamic contains { get; set; }

        public returnObjEngine(dynamic Contains = null)
        {

            this.before = null;
            this.contains = Contains;

        }

    }
}
