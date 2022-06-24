using System;
namespace Program
{
    class Patika{
        static void Main(string[] args)
        {
            byte b = 5;
            sbyte c = 5;
            short s = 5;
            ushort u = 5;

            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            Int64 i64 = 2;

            uint ui = 2;
            long l = 4;
            ulong ul = 4;

            float f = 5.2f;
            double d = 5;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 5;

            string str1 = string.Empty;
            str1 = "Nafi Kirman";
            string ad = "Nafi";
            string soyad = "Kirman";
            string tamIsim = ad + " " + soyad;
            Console.WriteLine(tamIsim);

            int integer = 5;
            int integer2 = 3;
            int integer3 = integer + integer2;

            bool bool1 = 10 < 2;
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

        }
    }
}
