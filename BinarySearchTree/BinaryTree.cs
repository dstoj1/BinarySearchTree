using System;
using System.Collections;

namespace BinarySearchTree
{
    class BinaryTree
    {
        private Node root;
        private Node value;
        private object data;
        private object compare;

        public BinaryTree()
        {
            root = null;
        }
        public void Display()
        {
            Display(root, 0);
            Console.WriteLine();
        }
        public void Display(Node node, int level)
        {
            if (node == null)
            {
                return;
            }

            Display(node.rightChild, level + 1);
            Console.WriteLine();

            for (int i = 0; i < level; i++)
            {
                Console.Write("    ");
            }
            Console.Write(node.data);

            Display(node.leftChild, level + 1);
        }
        public void CreateTree()
        {
            root = new Node(33);
            root.leftChild = new Node(44);
            root.rightChild = new Node(55);
            root.leftChild.leftChild = new Node(43);
            root.leftChild.rightChild = new Node(65);
            root.rightChild.leftChild = new Node(35);
        }
        public void AddToTree()
        {
            root.rightChild.rightChild = new Node(53);
            root.leftChild.leftChild.leftChild = new Node(73);
            root.leftChild.leftChild.rightChild = new Node(75);
        }
        public void InOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            InOrder(node.leftChild);
            Console.Write(node.data + " ");
            InOrder(node.rightChild);
        }
        void array_to_bst(int arr, Node root, int indexptr)
        {
            if (root != null)
            {
                array_to_bst(arr, root > l, indexptr);
                root,  value = arr[i++];
                array_to_bst(arr, root > r, indexptr);
            }
        }

        private void array_to_bst(int arr, bool v, int indexptr)
        {
            throw new NotImplementedException();
        }
        void binary_to_bst(Node root)
        {
            int n, i;

            if (root == null)
                return;
            n = count(root);
            i = 0;
            InOrder(root, data, i);
            qsort(data, n, sizeof (data[0]), compare);
            i = 0;
            array_to_bst(data, root, i);
        }

        private void qsort(object data, int n, int v, object compare)
        {
            throw new NotImplementedException();
        }

        private void array_to_bst(object data, Node root, int i)
        {
            throw new NotImplementedException();
        }

        private unsafe void qsort(object* v1, int n, int v2, object compare)
        {
            throw new NotImplementedException();
        }

        private void InOrder(Node root, object data, int i)
        {
            throw new NotImplementedException();
        }

        private int count(Node root)
        {
            throw new NotImplementedException();
        }
    }

    internal class data
    {
    }
}