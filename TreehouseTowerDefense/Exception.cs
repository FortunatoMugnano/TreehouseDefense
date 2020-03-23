using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseTowerDefense
{
    class TreehouseDefenseException : System.Exception
    {
        public TreehouseDefenseException(string message) : base(message)
        {

        }
    }

    class OutOfBoundException : TreehouseDefenseException
    {
        public OutOfBoundException(string message) : base(message)
        {

        }
    }
}
