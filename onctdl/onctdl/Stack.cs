using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onctdl
{
    class Stack
    {

        private Node _top;
        private int _size;

        public Node Top
        {
            get { return _top; }
        }
        public int Count
        {
            get { return _size; }
        }

        public Stack()
        {
            _top = null;
            _size = 0;
        }

        public void Push(int value)
        {
            Node pNew = new Node(value);
            if (_top == null)
            {
                _top = pNew;
            }
            else
            {
                pNew.Next = _top;
                _top = pNew;
            }
            _size++;
        }
        public int Pop()
        {
            int temp = 0;
            if (_top != null)
            {
                temp = _top.Data;
                _top = _top.Next;
                _size--;
            }
            return temp;
        }
        public int Peek()
        {
            if (_top == null)
            {
                throw new Exception("hang doi trong");
            }

            return _top.Data;
        }
    }
}
