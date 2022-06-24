using System;

namespace Pratikler
{
    class Operators
    {
        static void Main2(string[] args)
        {
            int x = 2;
            int y = 3;
            y += 2;
            Console.WriteLine(y);
            x -= 2;
            Console.WriteLine(x);

            bool isSucces = true;
            bool isComplated = false;

            bool sonuc = x < y;

            if (isSucces && isComplated)
                Console.WriteLine("Perfect");
            
            if(isComplated || isSucces)
                Console.WriteLine("Great");

            if (!isComplated && isSucces)
                Console.WriteLine("Fine");

            Console.WriteLine(sonuc);
            sonuc = x> y;
            Console.WriteLine(sonuc);
            sonuc = x >= y;
            Console.WriteLine(sonuc);
            sonuc = x <= y;
            Console.WriteLine(sonuc);
            sonuc = x == y;
            Console.WriteLine(sonuc);
            sonuc = x != y;
            Console.WriteLine(sonuc);


            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);




        }
    }
}

