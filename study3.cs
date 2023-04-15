using System;
namespace study
{
    //속성 
    //객체 안에 있는 필드의 값을 취득 또는 설정하는 메서드이다.
    //필드를 반환하는 get엑세서와 필드에 값을 대입하는 set 엣세서로 구성된다
    //자바에서 setter, getter랑 비슷한 개념이다
    //인덱스(indexer)
    //객체를 배열처럼 취급하고자 할 때 사용한다
    //속성과 같이 get,set으로 구성
    //상속 - ':부모클래스명'을 붙인다
    /*
     class A{
        ~~
    }
    class B:A{
        ~~
    }
     */
    //sealed
    //상속되지 않도록 할 틀래스는 sealed를사용하여 봉인한다
    /*
     sealed class A{
        ~~~~ 
     }
     */
    //클래스를 상속했을때 부모클래스와 자식클래스 각각에 생성자가 있는 경우 부모클래스로부터 차례로 생성자가 작동한다
    //기본클래스의 생성자를 호출
    //상속한 생성자에 인수가 있는 경우에는 다음과 같이 base를 이용하여 상속원본에 인수를 전달
    //이름 은폐
    //자식 클래스의 멤버에 부모클래스의 멤버와 같은 이름을 붙이고자 할 경우에는 멤버의 정의 앞에 'new'를 붙인다
    //여기서 new는 객체생성시 사용하는 new랑 다르다. new가 붙은 멤버를 호출하면서 자식클래스 쪽의 멤버가 호출된다
    //base
    //이름이 은폐된 부모클래스의 멤버를 자식클래스안에서 사용할 때 사용
    //오버라이드
    //상속한 메서드와 같은 이름, 같은 인수, 같은 반환값을 가지는 메서드를 해서 덮어 쓰는 것
    //오바라이드 되는 메소드에는 'virtual'키워드를 붙이고 오버라이드 한 메소드에는'override'키워드를 붙인다
    /*
    class HG
    {
        public virtual void bye() {
            Console.WriteLine("hello");
        }
    }
    class MG
    {
        public override void bye() {
            Console.WriteLine("world");
        }
    }
    */
    class bn
    {
        public int a = 10;
    }
    class bm : bn
    {
        new public int a = 30;
        //base 추가
        public void print()
        {
            Console.WriteLine(base.a);
        }
    }
    class lo
    {
        public int x;
        public lo(int a,int b)
        {
            x = a + b;
        }
    }
    class lp : lo
    {
        public lp(int c,int d) : base(c, d) {}
    }
   class k
    {
        int[] a = new int[4];
        public int this[int i]
        {
            get
            {
                return a[i];
            }
            set
            {
                a[i] = value;
            }
        }
    }
    class num
    {
        static void HHHH(string[] avgs)
        {
            k k = new k();
            k[0] = 1;
            k[1] = 2;
            k[2] = 3;
            k[3] = 4;
            for(int i = 0; i <= 3; i++)
            {
                Console.Write(k[i]);
            }
        }
    }    
}
