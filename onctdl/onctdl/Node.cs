using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onctdl
{
    class Node
    {
        private int data;
        private Node next;
        public Node(int value)// new Node(10) // [10][null]
        {
            data = value;
            next = null;
        }

        public int Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        internal Node Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }
    }
}
