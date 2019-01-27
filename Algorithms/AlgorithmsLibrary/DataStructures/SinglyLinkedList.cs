using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.DataStructures
{
    /// <summary>
    /// SinglyLinkedListNode
    /// </summary>
    public class SinglyLinkedListNode
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="x"></param>
        public SinglyLinkedListNode(int x)
        {
            Val = x;
        }

        /// <summary>
        /// Value 
        /// </summary>
        public int Val;

        /// <summary>
        /// Pointer to the next node
        /// </summary>
        public SinglyLinkedListNode Next;

    }
}
