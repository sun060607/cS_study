using System;
namespace study
{
    class Program
    {
        //c랑 마찬가지로 명령어로 변수 이림을 선언할 수 없으며 
        //숫자가 먼저와서는 안된다
        //기존 c의 변수 선언 방법 참고
        static void Main(string[] args)
        {
            bool Number = true;
            int num1 = 10;
            double num2 = 10.34;
            char num3 = 'B';
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(Number);
            Console.WriteLine("Hello World");
        }
    }
}