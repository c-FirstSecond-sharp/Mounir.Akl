using Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComdepConfig.Main_Code_Pool.Abstracts
{
    public abstract class Node
    {
       
        //private Node m_next;
        //public Node Next { get { return m_next; } }
        //public Node(Node next) { m_next = next; }

        public abstract One ConstructOne(Node other);
        public abstract One ConstructOne<TFirst>(Node<TFirst> other) where TFirst : class;
       
    }
    public class Node<T> : Node where T : class
    {
        private AM<T> m_data;
        public AM<T> Data { get { return m_data; } }
        public Node(T data)
        //: base(next)
        {
            m_data = data;
        }

        public override One ConstructOne(Node secondNode)
        {
            return secondNode.ConstructOne<T>(this);
        }

        public override One ConstructOne<TFirst>(Node<TFirst> firstNode)
        {
            return new One<Node<TFirst>>(firstNode);
        }
       

       
    }
}
