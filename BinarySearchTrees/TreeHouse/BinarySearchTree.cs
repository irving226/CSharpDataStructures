using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHouse
{
    class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int val;

        public TreeNode(TreeNode left = null, TreeNode right = null, int val = 0)
        {
            this.left = left;
            this.right = right;
            this.val = val;
        }
    }
    class BinarySearchTree
    {
        public TreeNode root;
        public BinarySearchTree()
        {
            this.root = null;
        }

        public void Insert(int num)
        {
            TreeNode node = new TreeNode();
            node.val = num;
            if (root == null)
            {
                root = node;
            }
            else
            {
                TreeNode currentNode = root;
                while (true)
                {
                    if (node.val < currentNode.val)
                    {
                        if (currentNode.left == null)
                        {
                            currentNode.left = node;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.left;
                        }
                    }
                    if (node.val > currentNode.val)
                    {
                        if (currentNode.right == null)
                        {
                            currentNode.right = node;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }
                }
            }

        }
        public bool Lookup(int val)
        {

            TreeNode searchedForNode = new TreeNode();
            searchedForNode.val = val;
            TreeNode currentNode = root;
            bool isPresent = false;

            while (isPresent == false)
            {
                if (currentNode == null)
                {
                    break;
                }

                if (searchedForNode.val == currentNode.val)
                {
                    isPresent = true;
                }

                while (currentNode != null)
                {
                    if (currentNode.val == val)
                    {
                        return true;

                    }
                    else if (val < currentNode.val)
                    {
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            }
            return isPresent;
        }

        public TreeNode SearchBST(TreeNode root, int val)
        {
            //
            if (root == null)
            {
                return null;
            }

            if (root.val == val)
            {
                return root;
            }

            TreeNode pointerNode = new TreeNode();
            pointerNode = root;
            while (pointerNode != null)
            {
                if (val < pointerNode.val && pointerNode.left != null)
                {
                    pointerNode = pointerNode.left;
                }
                else if (val > pointerNode.val && pointerNode.right != null)
                {
                    pointerNode = pointerNode.right;
                }
                else if (pointerNode.val == val)
                {
                    root = pointerNode;
                    break;
                }
                else
                {
                    pointerNode = null;
                }
            }
            BinarySearchTree subTree = new BinarySearchTree();
            subTree.root = pointerNode;


            return subTree.root;
        }

        public IList<int> PreorderTraversal(TreeNode root)
        {

           
            IList<int> nodes = new List<int>();
            TreeNode pointerNode = new TreeNode();
           

            if (root == null)
            {
                return nodes;
            }
            pointerNode = root;
            nodes.Add(pointerNode.val);
            if (pointerNode.left != null)
            {
               
               
               
                nodes=nodes.Concat(PreorderTraversal(pointerNode.left)).ToList();
                nodes=nodes.Concat(PreorderTraversal(pointerNode.right)).ToList(); 
            }

           else if(pointerNode.right!= null)
            {
                nodes=nodes.Concat(PreorderTraversal(pointerNode.left)).ToList(); 
                nodes=nodes.Concat(PreorderTraversal(pointerNode.right)).ToList(); 
            }
            
            return nodes;

             


        }




    }
}



