using System;

// README.md를 읽고 아래에 코드를 작성하세요.
using FormalMsg = Formal.Message;
using CasualMsg = Casual.Message;

Console.WriteLine("=== 인사 테스트 ===");

Console.WriteLine("[격식체]");

FormalMsg formalMessage = new FormalMsg();
formalMessage.SayHello("홍길동");
formalMessage.SayBye("홍길동");

Console.WriteLine();

Console.WriteLine("[비격식체]");

CasualMsg casualMessage = new CasualMsg();
casualMessage.SayHello("철수");
casualMessage.SayBye("철수");
