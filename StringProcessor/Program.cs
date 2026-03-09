using System;
static string Original(string s) => "Hello World";
static string ToUpperCase(string s)=> s.ToUpper();
static string ToLowerCase(string s)=> s.ToLower();
static string AddBrackets(string s)=> "[" + s + "]";
static string Reverse(string s)
{
    char[] chars = s.ToCharArray();
    Array.Reverse(chars);
    string revers = new string(chars);
    return revers;
}
Console.WriteLine("=== 문자열 가공기 ===");
Console.WriteLine();
StringProcessor str = Original;
Console.WriteLine($"원본: {str("")}");
Console.WriteLine();
Console.WriteLine("[대문자 변환]");
str += ToUpperCase;
Console.WriteLine($"결과: {str("Hello World")}");
Console.WriteLine();
Console.WriteLine("[소문자 변환]");
str -= ToUpperCase;
str += ToLowerCase;
Console.WriteLine($"결과: {str("Hello World")}");
Console.WriteLine();
Console.WriteLine("[괄호 추가]");
str -= ToLowerCase;
str += AddBrackets;
Console.WriteLine($"결과: {str("Hello World")}");
Console.WriteLine();
Console.WriteLine("[문자열 뒤집기]");
str -= AddBrackets;
str += Reverse;
Console.WriteLine($"결과: {str("Hello World")}");
Console.WriteLine();
delegate string StringProcessor(string s);
