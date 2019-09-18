using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binarytree
{
  public class Program
    {
      
        static void Main(string[] args)
        {
            BinarySearchTree Bi = new BinarySearchTree();
           Bi.Insert(50);
            Bi.Insert(40);
            Bi.Insert(65);
            Bi.Insert(33);

            bool cool = Bi.Search(40);

        }
    }
}
