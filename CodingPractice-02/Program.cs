using System;

//1.인스턴스 메서드 참조
/*Calculator calc = new Calculator();
Transformer t = calc.Multiply;
Console.WriteLine(t(5));

delegate int Transformer(int x);

class Calculator
{
    public int multiplier = 3;
    public int Multiply(int x) => x * multiplier;
}*/

//2. 멀티캐스트 대리자: 추가와 제거
/*static void GoForward() => Console.WriteLine("직진");
static void GoLeft() => Console.WriteLine("좌회전");
static void GoRight() => Console.WriteLine("우회전");

CarDriver go = GoForward;
go += GoLeft;
go += GoRight;
go();

Console.WriteLine();

go -= GoLeft;
go();

delegate void CarDriver();
*/
//3. 배열 변환 예제
static int Square(int x) => x * x;
static int Cube(int x) => x * x * x;

static void Transform(int[] values, Transformer t)
{
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = t(values[i]);
    }
}

static void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(", ", arr));
}

int[] numbers = { 1, 2, 3, 4, 5 };

Transform(numbers, Square);
PrintArray(numbers);

numbers = new int[] { 1, 2, 3, 4, 5 };


Transform(numbers, Cube);
PrintArray(numbers);

delegate int Transformer(int x);

