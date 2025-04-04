using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    public class Node
    {
        public object inf; //информационное поле
        public Node left; //ссылка на левое поддерево
        public Node right; //ссылка на правое поддерево
        public int height;

        //конструктор вложенного класса, создает узел дерева
        public Node(object nodeInf)
        {
            inf = nodeInf;
            left = null;
            right = null;
            height = 1;
        }

        public Node(Node node)
        {
            inf = node.inf;
            left = node.left;
            right = node.right;
            height = node.height;
        }

        public int GetHeight()
        {
            return (this != null) ? this.height : 0;
        }

        public static void UpdateHeight(Node node)
        {
            int rh = (node.right != null) ? node.right.height : 0;
            int lh = (node.left != null) ? node.left.height : 0;
            node.height = ((rh > lh) ? rh : lh) + 1;

        }

        //добавляет узел в дерево так, чтобы дерево оставалось деревом бинарного поиска
        public static void Add(ref Node r, object nodeInf)
        {
            if (r == null)
            {
                r = new Node(nodeInf);
            }
            else
            {
                if (((IComparable)(r.inf)).CompareTo(nodeInf) > 0)
                {
                    Add(ref r.left, nodeInf);
                }
                else
                {
                    Add(ref r.right, nodeInf);
                }
            }
            UpdateHeight(r);
        }

        //прямой обход дерева
        public static void Preorder(Node r)
        {
            if (r != null)
            {
                Console.Write("({0}, {1})", r.inf, r.height);
                Preorder(r.left);
                Preorder(r.right);
            }
        }

        //симметричный обход дерева
        public static void Inorder(Node r)
        {
            if (r != null)
            {
                Inorder(r.left);
                Console.Write("{0} ", r.inf);
                Inorder(r.right);
            }
        }

        //обратный обход дерева
        public static void Postorder(Node r)
        {
            if (r != null)
            {
                Postorder(r.left);
                Postorder(r.right);
                Console.Write("{0} ", r.inf);
            }
        }

        //поиск ключевого узла в дереве
        public static void Search(Node r, object key, out Node item)
        {
            if (r == null)
            {
                item = null;
            }
            else
            {
                if (((IComparable)(r.inf)).CompareTo(key) == 0)
                {
                    item = r;
                }
                else
                {
                    if (((IComparable)(r.inf)).CompareTo(key) > 0)
                    {
                        Search(r.left, key, out item);
                    }
                    else
                    {
                        Search(r.right, key, out item);
                    }
                }
            }
        }



        //методы Del и Delete позволяют удалить узел в дереве так, чтобы дерево при этом
        //оставалось деревом бинарного поиска
        private static void Del(Node t, ref Node tr)
        {
            if (tr.right != null)
            {
                Del(t, ref tr.right);
            }
            else
            {
                t.inf = tr.inf;
                tr = tr.left;
            }
        }

        public static void Delete(ref Node t, object key)
        {
            if (t == null)
            {
                throw new Exception("Данное значение в дереве отсутствует");
            }
            else
            {
                if (((IComparable)(t.inf)).CompareTo(key) > 0)
                {
                    Delete(ref t.left, key);
                }
                else
                {
                    if (((IComparable)(t.inf)).CompareTo(key) < 0)
                    {
                        Delete(ref t.right, key);
                    }
                    else
                    {
                        if (t.left == null)
                        {
                            t = t.right;
                        }
                        else
                        {
                            if (t.right == null)
                            {
                                t = t.left;
                            }
                            else
                            {
                                Del(t, ref t.left);
                            }
                        }
                    }
                }
            }
            if (t != null)
            {
                UpdateHeight(t);
            }
        }

        public int BalanceFactor
        {
            get
            {
                int rh = (this.right != null) ? this.right.height : 0;
                int lh = (this.left != null) ? this.left.height : 0;
                return rh - lh;
            }
        }

        public override string ToString()
        {
            return $"inf: {inf}, height: {height}";
        }

    }
}
