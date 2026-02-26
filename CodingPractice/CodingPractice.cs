using System;
using System.Collections.Generic;
using System.Text;

namespace Foo
{
    public class Car
    {
        public void Go()
        {
            Console.WriteLine("Foo 네임스페이스의 Car 클래스");
        }
    }
}

namespace Bar
{
    public class Car
    {
        public void Go()
        {
            Console.WriteLine("Bar 네임스페이스의 Car 클래스");
        }
    }
}

namespace Korea.Seoul
{
    public class Car
    {
        public void Run()
        {
            Console.WriteLine("서울 자동차가 달립니다.");
        }
    }
}

namespace Korea.Incheon
{
    public class Car
    {
        public void Run()
        {
            Console.WriteLine("인천 자동차가 달립니다.");
        }
    }
}