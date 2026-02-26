using System;
using System.Collections.Generic;
using System.Text;

namespace Formal
{
    public class Message
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"{name}님, 안녕하십니까!");
        }

        public void SayBye(string name)
        {
            Console.WriteLine($"{name}님, 안녕히 가십시오!");
        }
    }
}