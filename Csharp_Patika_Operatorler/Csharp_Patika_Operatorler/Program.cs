using System;

namespace Csharp_Patika_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y + 2;
            y += 5;

            Console.WriteLine(y += 10);

            Console.WriteLine(y -= 5);

            Console.WriteLine(y *= 2);

            Console.WriteLine(y /= 3);

            //Mantıksal Operatörler
            // ||(veya), &&(ve), !(Değil)

            bool isSuccess = true;
            bool isComleted = false;


            if (isSuccess && isComleted)
                Console.WriteLine("perfect!");

            if (isSuccess || isComleted)
                Console.WriteLine("Great!");

            if (isSuccess && ! isComleted)
                Console.WriteLine("FİNE!");

            //İlişkisel Operatörler
            // <,>,<=,>=,==,!=


            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);

            // % mod alır
            int sonuc2 = 2354;
            Console.WriteLine(sonuc2);








        }
    }
}
