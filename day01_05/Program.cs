using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01_05
{
    class Motherc
    {
        virtual public void Move()
        {
            Console.WriteLine("움직인다.");
        }
    }

    class Lion : Motherc
    {
        override public void Move()
        {
            Console.WriteLine("네 발로 움직인다");
        }
    }

    class Whale : Motherc
    {
        override public void Move()
        {
            Console.WriteLine("수영한다.");
        }
    }

    class Human : Motherc
    {
        new public void Move()
        {
            Console.WriteLine("두 발로 걷는다.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //ans01과 02는 같은 의미이며, 메서드 오버라이드를 이용한 것이다.
            // 오버라이드를 위해서는 피오버라이드 함수에는 virtual을 오버라이드를 하는 주체에는 override를 적는다.
            Lion temp01 = new Lion();
            Motherc ans01 = temp01;
            ans01.Move();

            Motherc ans02 = new Lion();
            ans02.Move();

            //Human클래스는 new를 이용하여 동일한 이름의 메서드를 사용한 것이다.
            Human ans03 = new Human();
            ans03.Move();

            //오버라이드가 수행되지않아 부모클래스의 함수가 사용되었다.
            Motherc ans04 = new Human();
            ans04.Move();
        }
    }
}
