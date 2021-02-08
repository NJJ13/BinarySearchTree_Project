using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public Node RootNode;


        public void AddNode(Node nodeToAdd)
        {
            if (RootNode == null)
            {
                RootNode = nodeToAdd;
            }
            else
            {
                Node focusNode = RootNode;
                while (true)
                {
                    if (focusNode.ChildNodes[0] == null && nodeToAdd.data < focusNode.data)
                    {
                        focusNode.ChildNodes[0] = nodeToAdd;
                        break;
                    }
                    else if(focusNode.ChildNodes[1] == null && nodeToAdd.data > focusNode.data)
                    {
                        focusNode.ChildNodes[1] = nodeToAdd;
                        break;
                    }
                    else if(nodeToAdd.data < focusNode.data)
                    {
                        focusNode = focusNode.ChildNodes[0];
                        continue;    
                    }
                    else if(nodeToAdd.data > focusNode.data)
                    {
                        focusNode = focusNode.ChildNodes[1];
                        continue;
                    }

                }
            }
        }
        public Node SearchTree(Node nodeToSearch)
        {
            Node focusNode = RootNode;
            while (true)
            {
                if (RootNode == null)
                {
                    Console.WriteLine("The data you are looking for does not exist within this tree.");
                    return null;
                }
                else
                {
                    if (nodeToSearch.data < focusNode.data)
                    {
                        if (focusNode.ChildNodes[0] == null)
                        {
                            Console.WriteLine("The data you are looking for does not exist within this tree.");
                            return null;
                        }
                        else if (focusNode.ChildNodes[0].data == nodeToSearch.data)
                        {
                            return focusNode.ChildNodes[0];
                        }
                    }
                    else if (nodeToSearch.data > focusNode.data)
                    {
                        if (focusNode.ChildNodes[1] == null)
                        {
                            Console.WriteLine("The data you are looking for does not exist within this tree.");
                            return null;

                        }
                        else if (focusNode.ChildNodes[1].data == nodeToSearch.data)
                        {
                            return focusNode.ChildNodes[1];
                        }
                    }
                    else if (nodeToSearch.data < focusNode.data && nodeToSearch.data != focusNode.data)
                    {
                        focusNode = focusNode.ChildNodes[0];
                        continue;
                    }
                    else if (nodeToSearch.data > focusNode.data && nodeToSearch.data != focusNode.data)
                    {
                        focusNode = focusNode.ChildNodes[1];
                        continue;
                    }
                    
                }
                
            }
        }
    }
}
