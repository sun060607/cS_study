using System;
class Read
{
    static void Main()
    {
        //시프트 연산자
        int a = 616;
        Console.WriteLine(a << 4);
        //0000001001101000
        //0010011010000000
        Console.WriteLine(a >> 4);
        //0000001001101000
        //0000000000100110 //1000 버려짐
        //do while
        //뒤에 조건이 있어 무조건 처음에는 실행

        int num1 = 1;
        do
        {
            Console.WriteLine("num: {0}", num1++);
        } while (num1 <= 10);
    }
}
