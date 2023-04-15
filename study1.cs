using System;
using System.ComponentModel.DataAnnotations;

namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "hello";
            Console.Write(num);//줄 바꿈 없음
            int num2 = 10;
            string num3 = num2 + num;//연결 하려면 +를 이용하여 사용 가능ㄹ
            Console.WriteLine(num3);
            //1차원 배열
            int[] a = new int[4];//범위지정
            int[] a1 = new int[]{ 1, 2, 3, 4 };//선언과 동시에 초기화
            int[] a2 ={ 1, 2, 3, 4 };//위와 같음
            //2차원 배열
            //쉼표로 열화 행을 구분
            int[,]b = new int [2,3];
            //3차원 배열
            int[,,] c = new int[2, 3, 4];
            //다차원 배열 초기화
            int[,] b1 =
            {
                {10,20},
                {30,40},
                {50,60}
            };
            //--------------------------
            //재그 배열
            int[][] jug = new int[3][];
            jug[0] = new int[3] { 1, 2, 3 };
            jug[1] = new int[2] { 1, 2 };
            jug[2] = new int[1] { 1 };
            int[][] jug2 = new int[][]{
                new int[]{1, 2, 3},
                new int[]{4, 5},
                new int[]{6}
            };
            //length 배열의 요소 수 구하기
            int[] len = new int[4];
            int len2 = len.Length;
            //조건 연산자
            bool bo = true;
            int bo1 = bo ? 100 : 10;//bo가 참이면 100을, 거짓이면 10을 a에 대입
            //캐스트 연산자 형명을(0으로 묶은 것. 값이나 변ㅅ 앞에 쓰면 지정한 형으로 변환할 수 있다
            int i = 3;
            int j = 2;
            int h = (int)1 / j;             
        }
    }
}
