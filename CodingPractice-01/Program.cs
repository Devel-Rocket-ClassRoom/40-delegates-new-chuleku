using System;
using System.Threading.Channels;
//1. 대리자를 통한 메서드 호출
/*static void Hello() => Console.WriteLine("Hello Delegate");

saydelegate saypointer = new saydelegate(Hello);

saypointer();

saypointer.Invoke();

delegate void saydelegate();
*/
//2. 대리자 인스턴스 생성 방법
/*static void Hi() => Console.WriteLine("안녕하세요.");
SayDelegate sayDelegate = Hi;

sayDelegate();

var hi = new SayDelegate(Hi);
hi();

delegate void SayDelegate();*/

//3. 매개변수와 반환값이 있는 대리자
/*static double GetArea(int r) => 3.14 * r * r;
GetAreaDelegate pointer = GetArea;

Console.WriteLine(pointer.Invoke(10));
Console.WriteLine(pointer(10));

delegate double GetAreaDelegate(int r);
*/

//4. 강력한 형식의 대리자
/*MathOperation pow = Math.Pow;

double result = pow(2, 10);
Console.WriteLine(result);

delegate double MathOperation(double x, double y);*/

//5. 정적 메서드 참조
/*Transformer t = Calculator.Square;
Console.WriteLine(t(5));

delegate int Transformer(int x);


class Calculator
{
    public static int Square(int x) => x * x;

}*/
// 6. 멀티캐스트 대리자: 진행률 보고
/*static void WriteToConsole(int p)
{
    Console.WriteLine($"진행률: {p}%");
}
static void WriteToFile(int p)
{
    Console.WriteLine($"[파일 기록] {p}%");
}
ProgressReporter program = WriteToConsole;
program += WriteToFile;
for (int i =0; i <=100;i+=25)
{
    program(i);
    Console.WriteLine();
}


delegate void ProgressReporter(int p);
*/
//7. 대리자를 매개변수로 전달
/*static void go()
{
    Console.WriteLine("직진");
}
static void Back()
{
    Console.WriteLine("후진");
}
static void RunnerCall(Runner runner)
{
    Console.WriteLine("=== 실행 시작 ===");
    runner();
    Console.WriteLine("=== 실행 종료 ===");
}

RunnerCall(go);
Console.WriteLine();
RunnerCall(Back);

delegate void Runner();
*/
//8. Action 대리자
/*Action greet = () => Console.WriteLine("안녕하세요!");
greet();
Action<string> print = (msg) => Console.WriteLine(msg);
print("Hello, Action!");

Action<string, int> printRepeat = (msg, count) =>
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(msg);
    }
};
printRepeat("반복", 3);*/

//9. Func 대리자

/*Func<int> num = () => 42;
Console.WriteLine(num());
Func<int, int> Square = (x) => x * x;
Console.WriteLine(Square(5));
Func<int,int,int> add = (a,b) => a + b;
Console.WriteLine(add(3, 7));
Func<int,int,string> addtostring = (a,b)=>(a+b).ToString();
Console.WriteLine(addtostring(3,5));*/

//10. predicate 대리자
/*Predicate<int> isEven = (x) => x % 2 == 0;
Predicate<int> isPositive = (x) => x > 0;

Console.WriteLine(isEven(4));      
Console.WriteLine(isEven(7));      
Console.WriteLine(isPositive(5));  
Console.WriteLine(isPositive(-3)); */

//11.익명 메서드
SayDeleGate say = delegate ()
{
    Console.WriteLine("반갑습니다.");
};
say();
delegate void SayDeleGate();
