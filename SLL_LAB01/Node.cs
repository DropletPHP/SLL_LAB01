using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLL_LAB01
{
    internal class Node
    {
        public string Value { get; set; }
        /// <summary>
        /// The value in the node
        /// </summary>
        public Node Next { get; set; }

        public Node(string value)
        {
            Value = value;
            Next = null;
        }
    }
}
