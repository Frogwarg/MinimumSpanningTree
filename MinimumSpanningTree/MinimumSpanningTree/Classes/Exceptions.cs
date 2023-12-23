using System;

namespace MinimumSpanningTree
{
    public class Exceptions : Exception
    {
        public Exceptions() { }
        public Exceptions(string message) : base(message) { }
        public Exceptions(string message, Exception e) : base(message, e) { }
    }
}
