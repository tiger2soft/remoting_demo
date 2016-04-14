using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteObject
{
    public class MyObject : MarshalByRefObject
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
