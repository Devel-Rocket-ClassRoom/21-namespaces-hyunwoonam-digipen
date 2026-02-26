using System;
using System.Collections.Generic;
using System.Text;

namespace Casual
{
    public class Message
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"안녕, {name}!");
        }

        public void SayBye(string name)
        {
            Console.WriteLine($"잘 가, {name}!");
        }
    }
}
