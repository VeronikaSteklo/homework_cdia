using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    public class Node
    {
        public int Inf { get; set; }
        public Node Next { get; set; }

        public Node(int inf)
        {
            Inf = inf;
            Next = null;
        }
    }
}
