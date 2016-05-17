using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smil
{
    class returnObj
    {

        public returnObjEngine start { get; private set; }
        public returnObjEngine end { get; set; }

        public int maxIndex { get; private set; }
        private bool isCircular { get; set; }

        private returnObjEngine pointer;

        public dynamic this[int i]
        {
            get { return this.get(i).contains; }
            set { this.get(i).contains = value; }
        }

        public returnObj(dynamic Contains, bool isCircular = true)
        {
            returnObjEngine construct = new returnObjEngine(Contains);
            start = construct;
            end = construct;
            maxIndex = 1;
            this.isCircular = isCircular;

        }


        private returnObjEngine get(int i)
        {
            if (maxIndex < i)
            {
                returnObjEngine broke = new returnObjEngine("Out Of Bounds Error");
                Console.WriteLine("Out Of Bounds Error");
                Console.ReadKey();
                return broke;
            }
            else
            {
                pointer = start;
                for (int se = 1; se <= i; se++)
                {
                    pointer = pointer.next;
                }
                return pointer;

            }
        }

        public void remove(returnObjEngine pointer)
        {
            pointer.next.before = pointer.before;
            pointer.before.next = pointer.next;
            maxIndex--;
        }

        public void Add(dynamic Contains)
        {
            returnObjEngine entity = new returnObjEngine(Contains);
            end.next = entity;
            entity.before = end;
            end = entity;
            maxIndex++;
            if (isCircular)
            {
                end.next = start;
                start.before = end;
            }
        }

    }

}

