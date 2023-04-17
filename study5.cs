//using 지시어
//뒤에 지정한 네임스페이스를 이용한다는 것을 선언
//console클새스는 System 네임스페이스에 속한다
//스트림
//파일의 읽기 및 쓰기에 대한 데이터의 흐름을 스트림이라 한다
//C#에서는 스트림 전용 클래스에서 생성한 객체를 사용한다.
//스트림 클래스를 이용하려면 'using System.IO;'를 선언해야 한다
//예외처리
//try {예외가 발생할지 모르는 처리}
//catch(예외클래스명 변수명){예외 발생시 실행하는 처리}
//finally{뒷 마무리 작업}
//문자 읽기
//1. 파일 열기
//FileStream클래스를 사용하여 스트림을 만들고 StreamReader라는 읽기용 클래스에 전달
//FileStream fs = newStream("A.txt","FileMode.Open");//A.txt는 파일이름이고 FileMode는 열기모드이다
//StreamReader r = new StreamReader(fs);
//열기 모드
//FileMode.Open: 기존파일을 연다
//FileMode.OpenOrCreate: 파일이 업으면 만들어서 연다
//FileMode.Append : 추가모드로 연다. 파일이 없으면 만든다
//FileMode.Create: 파일을 만든다. 같은 이름 파일이 있으면 이전 파일 지우고 만든다
//FileMode.CreateNew: 파일을 만든다. 같은 이름 파일이 있으면 예외가 발생한다
//2.데이터를 읽는다
//StreamReader클래스의 ReadLine()메서드를 사용한다
//string s = r.ReadLine(); // ReadLine는 한행의 문자열을 읽는다
//3.파일을 닫는다
//StreamReader클래스의 close()메소드 사용
//r.close();
using System;
using System.IO;
class Read
{
    static void Main()
    {
        FileStream fs;
        try
        {
            fs = new FileStream("C:\\Users\\sung0\\Desktop\\사적\\수행평가.txt", FileMode.Open);     //A.txt는 실행파일과 같은 위치에 준비한다.
        }
        catch (IOException)
        {
            Console.WriteLine("파일을 열 수 없음");
            return;
        }
        StreamReader r = new StreamReader(fs);
        string s;
        while ((s = r.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }
        r.Close();
    }
}
