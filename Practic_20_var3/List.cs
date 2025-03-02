using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    public class List
    {
        private Node head;
        private Node tail;

        public List()
        {
            head = null;
            tail = null;
        }

        public void AddBegin(int nodeInfo)
        {
            Node r = new Node(nodeInfo);
            if (head == null)
            {
                head = r;
                tail = r;
            }
            else
            {
                r.Next = head;
                head = r;
            }
        }

        public void AddEnd(int nodeInfo)
        {
            Node r = new Node(nodeInfo);
            if (head == null)
            {
                head = r;
                tail = r;
            }
            else
            {
                tail.Next = r;
                tail = r;
            }
        }

        public int TakeBegin()
        {
            if (head == null)
            {
                throw new Exception("Список пуст");
            }
            else
            {
                Node r = head;
                head = head.Next;
                if (head == null)
                {
                    tail = null;
                }
                return r.Inf;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return head == null;
            }
        }

        public Node Find(Node begin, object key)
        {
            Node r = begin;
            while (r != null)
            {
                if (((IComparable)(r.Inf)).CompareTo(key) == 0)
                {
                    break;
                }
                else
                {
                    r = r.Next;
                }
            }
            return r;
        }

        public Node Find(object key)
        {
            return Find(head, key);
        }

        public void Insert(Node begin, int item)
        {
            Node r = begin;
            if (r != null)
            {
                Node p = new Node(item);
                p.Next = r.Next;
                r.Next = p;
            }
        }

        public void Show(string outputFile)
        {
            Node r = head;
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                while (r != null)
                {
                    writer.Write("{0} ", r.Inf);
                    r = r.Next;
                }
                writer.WriteLine();
            }
        }
    }
}
