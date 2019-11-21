using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Problems
{
    class BstNode
    {
        public int data;
        public BstNode(int data)
        {
            this.data = data;
        }
        public BstNode left;
        public BstNode right;
    }
    class RootBinaryTree
    {
        public static BstNode Insert(BstNode root, int data)
        {
            if (root == null) root = new BstNode(data);
            else if (data <= root.data) root.left = Insert(root.left, data);
            else if (data > root.data) root.right = Insert(root.right, data);

            return root;
        }

        public static void RunRootTree()
        {
            // create/insert into BST
            BstNode Root = null;
            Root = Insert(Root, 15);
            Root = Insert(Root, 10);
            Root = Insert(Root, 20);
            Root = Insert(Root, 8);
            Root = Insert(Root, 12);
            Root = Insert(Root, 17);
            Root = Insert(Root, 25);

        }
    }
}
