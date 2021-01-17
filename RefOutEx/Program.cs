using System;

namespace RefOutEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int num0 = 10;
            Console.WriteLine("Value : " + num0);
            Change(num0);
            Console.WriteLine("After Change : " + num0);

            Console.WriteLine("------------Metoda gönderilen num0 klonlandı bu yüzden metot dışındaki num0 hiçbir şekilde etkilenmedi------------");

            int num1 = 10;
            Console.WriteLine("Value : " + num1);
            ChangeRef(ref num1);
            Console.WriteLine("After Change : " + num1);

            Console.WriteLine("------------num1 metoda referans olarak gönderildiği için metot içindeki değişiklikler metot dışındaki num1'i doğrudan etkiledi------------");

            int num2;
            Console.WriteLine("Value : Default");
            ChangeOut(out num2);
            Console.WriteLine("After Change : " + num2);

            Console.WriteLine("------------num2'nin değeri olmamasına rağmen metot içinde verdiğimiz değer metot dışında num2'yi etkileyebildi------------");

            Console.ReadLine();
        }

        public static void Change(int val)
        {
            val += 5;
        }

        public static void ChangeRef(ref int val)
        {
            val += 5;
        }

        public static void ChangeOut(out int val)
        {
            val = 10;
        }
    }
}
