using System;

// README.md를 읽고 아래에 코드를 작성하세요.

using static System.Console;
using static System.Math;

{
    Console.WriteLine("과제 1: 정규화된 이름으로 네임스페이스 사용");
    
    Foo.Car car1 = new Foo.Car();
    car1.Go();
    
    Bar.Car car2 = new Bar.Car();
    car2.Go();
}

Console.WriteLine();

{
    Console.WriteLine("과제 2: 중첩 네임스페이스 활용");

    Korea.Seoul.Car seoulCar = new Korea.Seoul.Car();
    seoulCar.Run();
    
    Korea.Incheon.Car incheonCar = new Korea.Incheon.Car();
    incheonCar.Run();
}

Console.WriteLine();

{
    Console.WriteLine("과제 3: using static 지시문");

    WriteLine("Hello, World!");
    
    WriteLine($"제곱근: {Sqrt(16)}");
    WriteLine($"최댓값: {Max(10, 20)}");
}



