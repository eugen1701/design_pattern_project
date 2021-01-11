using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project_Ex1
{
    public class Node<T>
    {
        T key;
        Node<T> next;
        public Node(T key)
        {
            this.key = key;
            this.next = null;
        }
        public T Key {
            get { return key; } 
            set { key = value; } 
        }
        public Node<T> Next {
            get { return next; }
            set { next = value; }
        }
        public override string ToString()
        {
            return this.key.ToString();
        }
    }
}

