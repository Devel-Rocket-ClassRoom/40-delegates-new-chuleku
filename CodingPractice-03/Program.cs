using System;
//1. 내장 대리자 (Action)로 멀티캐스트
/*static void GoForward() => Console.WriteLine("직진");
static void GoLeft() => Console.WriteLine("좌회전");
static void GoRight() => Console.WriteLine("우회전");

Action driver = GoForward;
driver += GoLeft;
driver += GoRight;

driver();*/
//2. 익명 메서드와 멀티캐스트
Action driver = GoForward;
driver += GoLeft;

driver += delegate ()
{
    Console.WriteLine("우회전");
};

driver();

static void GoForward() => Console.WriteLine("직진");
static void GoLeft() => Console.WriteLine("좌회전");