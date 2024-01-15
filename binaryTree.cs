using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            bt.Add(4);
            bt.Add(1);
            bt.Add(9);
            bt.Add(7);
            bt.Add(2);

            // bt.print(bt.Root);

            Console.WriteLine(bt.Root.Value);
            Console.WriteLine(bt.Root.Left.Value);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();        
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    class BinaryTree
    {
        private Node? _root;
        public Node? Root
        {
            get { return _root; }
            set { _root = value; }
        }
        public BinaryTree(Node? Root = null)
        {
            this.Root = Root;
        }

        public BinaryTree(int[] Numbers)
        {
            foreach (int number in Numbers)
            {
                Add(number);
            }
        }

        public void Add(int number)
        {
            if (Root == null)
            {
                Root = new Node(number);
                return;
            }
            else
            {
                if (number < Root.Value)
                {
                    ADD(Root.Left, number);
                }
                else
                {
                    ADD(Root.Right, number);
                }
            }
        }
        private void ADD(Node? node, int number)
        {
            if (node == null)
            {
                node = new Node(number);
            }
            else
            {
                node.Add(number);
            }
        }
        public void print(Node root)
        {
            Console.WriteLine(root.Value);
            if (root.Left != null)
            {
                print(root.Left);
            }
            if (root.Right != null)
            {
                print(root.Right);
            }
        }
        public void Print(Node? root = null)
        {
            if (root == null)
            {
                root = Root;
            }
            if (root.Left != null) //არსებობს //2.1
            {
                Print(root.Left);
            }
            else  //არ არსებობს //2.2
            {
                Console.WriteLine(root.Value);
                return;
            }

            Console.WriteLine(root.Value);   //3

            if (root.Right != null) //4.1
            {
                Print(root.Right);
            }
        }
    }
    class Node
    {
        private int? _value;
        private Node? _left;
        private Node? _right;

        public int? Value
        {
            get => _value;
            set => _value = value;
        }
        public Node? Left
        {
            get => _left;
            set => _left = value;
        }
        public Node? Right
        {
            get => _right;
            set => _right = value;
        }
        public Node(int? Val = null, Node? L = null, Node? R = null)
        {
            Value = Val;
            Left = L;
            Right = R;
        }

        public void Add(int number)
        {
            if (number > Value)
            {
                add(Right, number);
            }
            else
            {
                add(Left, number);
            }
        }
        private void add(Node node, int number)
        {
            if (node == null)
            {
                node = new Node(number);
            }
            else
            {
                node.Add(number);
            }
        }
    }
}

