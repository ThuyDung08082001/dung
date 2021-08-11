using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onctdl
{
    class Queue
    {
        private Node _front;
        private Node _rear;
        private int _count;

        internal Node Front
        {
            get
            {
                return _front;
            }
        }

        internal Node Rear
        {
            get
            {
                return _rear;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }

        }

        public Queue()
        {
            _front = null;
            _rear = null;
            _count = 0;
        }



        public void EnQueue(int value)
        {

            Node newNode = new Node(value);

            if (_front == null)
            {
                _front = newNode;
                _rear = newNode;
            }
            else
            {
                _rear.Next = newNode;
                _rear = newNode;
            }
            _count++;
        }


        public void Print()
        {
            for (Node p = _front; p != null; p = p.Next)
            {

                Console.WriteLine(p.Data);
            }
            Console.WriteLine();
        }

        public bool IsEmpty()
        {
            if (_front == null)
            {
                return true;
            }

            return false;
        }
        public int Peek()
        {
            if (_front == null)
            {
                throw new Exception("hang doi trong");
            }

            return _front.Data;
        }
        public int DeQueue()
        {
            if (_front == null)
            {
                throw new Exception("hang doi trong");
            }

            int temp = _front.Data;

            if (_front == _rear)
            {
                _front = null;
                _rear = null;
            }
            else
            {
                _front = _front.Next;
            }
            _count--;
            return temp;
        }

    }
}
