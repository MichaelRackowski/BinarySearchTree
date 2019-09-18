using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binarytree
{
    public class BinarySearchTree
    {
       public Node start;
        public Node current;
        public void Insert(int value)
        {
            Node node = new Node(value);
            if(start == null)
            {
                start = node;
                current = start;
                return;
            }

            if(value > current.number)
            {
                if(current.rightChild == null)
                {
                    current.rightChild = node;
                }
                else
                {
                    current = current.rightChild;
                    Insert(value);
                }
            }
            else if(value <= current.number)
            {
                if(current.leftChild == null)
                {
                    current.leftChild = node;
                }
                else
                {
                    current = current.leftChild;
                    Insert(value);
                }
            }
                current = start;
        }

        public bool Search(int value)
        {
          Node node = start;

            while(node != null)
            {
                if(value < node.number)
                {
                    node = node.leftChild;
                }
                else if(value > node.number)
                {
                    node = node.rightChild;
                }
                else if(value == node.number)
                {
                    return true;
                }
            }
                    return false;
        }
    }

}
            
            
            
            
     





       