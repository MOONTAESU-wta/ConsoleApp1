using System;
using static System.Console;
using MainSpace;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace MainSpace
{
    class MainClass
    {
        public static void DataSave(string n = "justBE")
        {
            int age = 100;
            double gain = 0.82;
            string name = n;

            Console.WriteLine(age);
            Console.WriteLine(gain);
            Console.WriteLine(name);

        }
    }

    class Person
    {
        public string name;
        public int age;
        public string gender;
        public ulong phone_num;

        public void Eat()
        {
            Console.WriteLine(name + "가 아침먹는다");
        }

        public ulong Check_PhoneNum()
        {
            return phone_num;
        }
    }
}

public class Example_Three
{
    // (1) 변수 선언과 초기화
    public enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    //Days today = Days.Monday;

    public void Examples_Print()
    {
        // 3장 enum 키워드
        Console.WriteLine("\n3장 enum 키워드");
        Example_Three.Days today = Example_Three.Days.Monday;
        Console.WriteLine("Today is: " + today);
        Console.WriteLine((int)today); // 1

        // 3장 var 키워드
        Console.WriteLine("\n3장 var 키워드");
        var age = 30;       // 컴파일러가 int로 추론
        var name = "Alice"; // 컴파일러가 string으로 추론

        // 3장 Nullable 형식
        Console.WriteLine("\n3장 Nullable 형식");
        int? score = null;
        if (score.HasValue) // HasValue은 null 유무 판단
            Console.WriteLine(score.Value);
        else
            Console.WriteLine("값이 없음");

        // 3장 문자열 보간
        Console.WriteLine("\n3장 문자열 보간");
        string message = $"나는 {age}살입니다." + "그리고 저는 " + name + "이라고합니다.";
        Console.WriteLine(message);

        // 3장 문자열 관련 메소드
        Console.WriteLine("\n3장 문자열 관련 메소드");
        string text = "C# Programing";
        Console.WriteLine(text.Length); // 문자열 길이
        Console.WriteLine(text.ToUpper()); // 대문자 변환
        Console.WriteLine(text.Substring(5)); // 부분 문자열
        Console.WriteLine(text.Contains("Pro")); // 포함여부

        // 3장 문자열(char) 다루기
        Console.WriteLine("\n3장 문자열(char) 다루기");
        char letter = 'A';
        Console.WriteLine(char.IsLetter(letter)); // 문자 여부
        Console.WriteLine(char.IsDigit(letter)); // 숫자 여부
        Console.WriteLine(char.IsWhiteSpace(letter)); // 공백여부

        // 3장 상수 문자열 포매팅
        Console.WriteLine("\n3장 상수 문자열 포매팅");
        string formatted = string.Format("이름 : {0}, 나이 : {1}", name, age);
        Console.WriteLine(formatted);


        Console.WriteLine("\n\n");
        // 4장
    }

}


class HelloWrold
{
    static void Main(string[] args)
    {

        if (args.Length == 0)
        {
            Example_Three ExTh = new Example_Three();
            ExTh.Examples_Print();



            //
            MainClass.DataSave();

            //
            Person person = new Person();
            person.name = "철수";
            person.Eat(); ;

            //
            person.phone_num = 01043210987;
            ulong phone_CkNum = person.Check_PhoneNum();
            Console.WriteLine("0{0}", phone_CkNum.ToString());


            return;
        }
        Console.WriteLine("HELLO, {0}", args[0]); ;
    }  
}


