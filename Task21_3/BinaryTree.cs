using System;
using System.Diagnostics.Metrics;

namespace tasks
{
    public class BinaryTree //класс, реализующий АТД «дерево бинарного поиска»
    {
        private Node tree; //ссылка на корень дерева

        //свойство позволяет получить доступ к значению информационного поля корня дерева
        public object Inf
        {
            set { tree.inf = value; }
            get { return tree.inf; }
        }

        //открытый конструктор
        public BinaryTree()
        {
            tree = null;
        }

        //закрытый конструктор
        private BinaryTree(Node r)
        {
            tree = r;
        }

        //добавление узла в дерево
        public void Add(object nodeInf)
        {
            Node.Add(ref tree, nodeInf);
        }

        //организация различных способов обхода дерева
        public void Preorder()
        {
            Node.Preorder(tree);
        }

        public void Inorder()
        {
            Node.Inorder(tree);
        }

        public void Postorder()
        {
            Node.Postorder(tree);
        }

        //поиск ключевого узла в дереве
        public BinaryTree Search(object key)
        {
            Node r;
            Node.Search(tree, key, out r);
            BinaryTree t = new BinaryTree(r);
            return t;
        }

        //удаление ключевого узла в дереве
        public void Delete(object key)
        {
            Node.Delete(ref tree, key);
        }

        public Queue<Node> GetUnbalancedNodes()
        {
            Queue<Node> unbalancedNodes = new Queue<Node>();
            CheckBalance(tree, unbalancedNodes);

            var sortedNodes = unbalancedNodes.OrderBy(node => node.GetHeight());

            return new Queue<Node>(sortedNodes);
        }

        private int CheckBalance(Node node, Queue<Node> unbalancedNodes)
        {
            if (node == null) return 0;

            int leftHeight = CheckBalance(node.left, unbalancedNodes);
            int rightHeight = CheckBalance(node.right, unbalancedNodes);

            if (node.BalanceFactor < -1 || node.BalanceFactor > 1)
                unbalancedNodes.Enqueue(node);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        public bool TryBalanceTree(int n, out List<Node> removedNodes)
        {
            removedNodes = new List<Node>();
            Queue<Node> unbalancedNodes = GetUnbalancedNodes();

            Console.WriteLine();

            if (unbalancedNodes.Count > n)
            {
                return false;
            }

            if (unbalancedNodes.Count == 0)
            {
                return true;
            }

            while (unbalancedNodes.Count > 0)
            {
                Node node = unbalancedNodes.Dequeue();

                if (Math.Abs(node.BalanceFactor) > n)
                {
                    return false;
                }
                while (Math.Abs(node.BalanceFactor) > 1 && removedNodes.Count < n)
                {
                    Node node1 = new Node(node);
                    Node node2 = new Node(node);
                    if (node1.BalanceFactor < -1)
                    {
                        while (node1.left != null)
                        {
                            node1 = node1.left;
                        }
                        removedNodes.Add(node1);
                        Delete(node1.inf);
                    }

                    if (node2.BalanceFactor > 1)
                    {
                        while (node2.right != null)
                        {
                            node2 = node2.right;
                        }
                        removedNodes.Add(node2);
                        Delete(node2.inf);
                    }
                }
            }

            Queue<Node> unbalancedNode = GetUnbalancedNodes();
            if (unbalancedNode.Count == 0)
            {
                return true;
            }

            return false;
        }

    }
}