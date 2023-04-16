using System;
namespace study
{
    //추상 클래스-추상 메서드를 가진 클래스이다
    //추상 메서드 -처리를 명시하지 않고 호출한 쪽만 정의한 메서드
    abstract class A
    {
        public abstract void Add();
    }
    //추상 클래스를 상속하여 객체를 생성하려면 다음과 같이 override 붙인 멤버를 준비한다
    class B : A
    {
        public override void Add()
        {
            Console.WriteLine("hello");
        }
    }
    //인터페이스 
    //추상 메서드,추상속성,추상인덱스,이벤트만 멤버로 가질 수 있다
    //인터페이스 정의에서 모든 메서드는 public로 취급하므로 액세스 수식자는 생략할 수 있다
    interface M
    {
        void a();
        int b
        {
            get;
            set;
        }
    }
    //인터페이스는 여러개 받을 수 있다
    //인터페이스의 상속
    //인터페이스도 클래스처럼 상속하여 새 인터페이스를 만들 수 있다
    interface V{}
    interface C : V{}
    //티페이스는 여러개 상속 가능하다
    //상속 원본의 인터페이스와 상속 대상의 인터페이스에 각각 같은 멤버가 있을 경우 상속 대상의 추상 멤버에 new를 붙인다
    //new 안 붙이면 경고
    interface G
    {
        void e();
        void f();
    }
    interface F:G
    {
        void a();
        new void e();
    }
    //네임스페이스 
    //같은 이름의 클래스 등이 경합을 일으키지 않도록 할 수 있게 한다
    namespace L
    {
        class Abc
        {

        }
        //네임 스페이스 안에 네임스페이스를 만들 수 있다
        namespace B
        {

        }
    }
   namespace L.B
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            //object클래스
            //모든 클래스의 기본이 되는 클래스이다. 모든 클래스는 object클래스를 상속하고 있다
            //박스화(boxing)
            //값형의 데이터를 객체형 변수에 대입하는 것
            int a = 10;
            object obj;
            obj = a;
            //박스화 해제
            //객체형의 데이터를 값형에 대입하는 것 형을 명확하기 하기 위해 형변환 사용
            obj = 10;
            int b = (int)obj;
            //네임 스페이스 안에 속해 있는클래스를 참조하려면 "."사용
            //L.Abc;
        }
    }
}
