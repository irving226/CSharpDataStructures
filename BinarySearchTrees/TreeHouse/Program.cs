using System;

namespace TreeHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree testTree = new BinarySearchTree();
            
            //TreeNode two = new TreeNode(null, null, 2);
            //TreeNode three = new TreeNode(null,null, 3);
            //TreeNode four = new TreeNode(null, null, 4);
            //TreeNode root = new TreeNode(three, four, 1);
            //root.right = three;
            //root.left = four;
            //four.left = two;

            TreeNode three = new TreeNode(null, null, 3);
            TreeNode two = new TreeNode(three, null, 2);
            TreeNode one = new TreeNode(null, two, 1);

            
           



           

            testTree.PreorderTraversal(one);





        }
    }
}
