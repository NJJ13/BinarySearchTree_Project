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
        public void SearchTree()
        {

        }
    }
}
