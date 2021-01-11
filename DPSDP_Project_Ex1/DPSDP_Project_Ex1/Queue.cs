using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project_Ex1
{
    public class Queue<T>: IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        public Node<T> Head {
            get { return head; } 
            set { head = value; }
        }
        public Node<T> Tail {
            get { return tail; }
            set { tail = value; } 
        }
        public Queue()
        {
            this.head = null;
            this.tail = null;
        }
        public void enqueue(T elem)
        {
            Node<T> temp = new Node<T>(elem);

            if (this.tail == null)
            {
                this.head = temp;
                this.tail = temp;
            }
            else 
            { 
            this.tail.Next = temp;
            this.tail = temp;
            }
        }

        public Node<T> dequeue()
        { 
            if (this.head == null)
                return null;

            Node<T> temp = this.head;
            this.head = this.head.Next;

            if (this.head == null)
                this.tail = null;

            return temp;
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = this.head;
            while (current != null)
            {
                yield return current.Key;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
