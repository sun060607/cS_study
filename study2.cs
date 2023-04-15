using System;
namespace study
{
    //클래스의 정의
    //필드 - 클래스 안의 '변수'를 뜻한다
    //메소드 - 클래스 안의 '함수'를 뜻한다
    //캍은 객체내의 필드나 메소드를 참조하려면 필드명, 메소드명을 그대로 써준다
    //다른 객체내의 필드나 메소드를 참조하려면'.(마침표)'를 사요하려면 '객체명.필드명'이런식으로 사용한다
    //오버로드(overload)
    //한 클래스 안에 이름이 같고 인수의 수나 형이 다른 메소드를 여러개 정의하는 것
    //이름이 같고 반환값이 다른 메소드는 오류가 뜬다
    //생성자 객체의 생성과 함께 자동으로 호출되는 것으로서 클래스와 같은 이름의 특수한 메소드이다
    //생성자를 작성하지 않으면 인수 없는 생성자가 자동으로 준비된다
    //이것을 '디폴트 생성자'라고 한다
    //복수의 생성자 
    //같은 클래스의 객체를 인수로 받아 대응하는 필드에 값을 대입하는 생성자를 복사 생성자라고 한다
    class I
    {
        public string title;
        public string writer;
        public I(string t, string w)
        {
            title = t;
            writer = w;
        }
        public I(I i)
        {
            title = i.title;
            writer = i.writer;
        }
    }
    class J
    {
        static void Main()
        {
            I i = new("책", "작가");
            I i2 = new I(i);
        }
    }
    class M
    {
        public int a, b;
        public M()//생성자의 반환 값은 없다
        {
            a = 0;
            b = 0;
        }
    }
    class A
    {
        public int a;//접근 제한자를 생략하면 private으로 설정됨
        public int b;
        public int add()
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            //------------------------------------------------------------------------------------------------
            //조건문
            //if (조건){내용} else if(조건){내용} else{내용}
            /*
            if (10 == 10)
            {
                Console.Write("정답");
            }else if (10 == 2)
            {
                Console.Write("정답2");
            }
            else
            {
                Console.Write("실패");
            }
            */
            //foreach문 배열같은 여러 데이터의 모음의 각 요소를 처음부터 끝까지 한번씩 호출하여 처리할때 사용하면 편리
            int[] nums = new int[5] { 1, 2, 3, 4, 5 };
            foreach (int k in nums)
                Console.WriteLine(k);
            }
        //while문 - while(조건) { 처리}
        //switch문 - switch(식){case 값1: 처리; break;....... }
        //클래스, 객체(Object) - 개념은 java의 클래스와 비슷하다
        //객체(Object) 
        //클래스를 실체화 한것.
        //클래스를 실체화하는 동작을 '인스턴스화하다' 또는 '객체를 생성하다라고 표현.
        //객체 생성 - new  연산자를 이용
        A h = new A();
        
    }
}
