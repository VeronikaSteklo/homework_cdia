using System;

namespace Task21_1
{
    public class BinaryTree //класс, реализующий АТД «дерево бинарного поиска»
    {
        //вложенный класс, отвечающий за узлы и операции допустимы для дерева бинарного поиска
        private class Node
        {
            public object inf; //информационное поле
            public Node left; //ссылка на левое поддерево
            public Node right; //ссылка на правое поддерево

            //конструктор вложенного класса, создает узел дерева
            public Node(object nodeInf)
            {
                inf = nodeInf;
                left = null;
                right = null;
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
            }

            //прямой обход дерева
            public static void Preorder(Node r)
            {
                if (r != null)
                {
                    Console.Write("{0} ", r.inf);
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
            public static Node Search(Node r, int key)
            {
                if (r == null || (int)r.inf == key)
                    return r;

                if (key < (int)r.inf)
                    return Search(r.left, key);
                else
                    return Search(r.right, key);
            }

            public static int CountDescendants(Node r)
            {
                if (r == null)
                    return 0;
                return 1 + CountDescendants(r.left) + CountDescendants(r.right);
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
            }
        }

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
        //public BinaryTree Search(object key)
        //{
        //    Node r;
        //    Node.Search(tree, key, out r);
        //    return new BinaryTree(r);
        //}

        //удаление ключевого узла в дереве
        public void Delete(object key)
        {
            Node.Delete(ref tree, key);
        }

        //подсчет количества потомков у заданного узла
        public int CountDescendants(int key)
        {
            Node node = Node.Search(tree, key);
            if (node == null)
                throw new Exception("Заданный узел не найден в дереве");
            return Node.CountDescendants(node) - 1; // Исключаем сам узел
        }
    }
}