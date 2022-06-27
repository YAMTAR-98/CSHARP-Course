using System;

namespace Program
{
    class try_catch_finally
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı gir: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş oldugunuz sayi : " + sayi); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());    
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }
            //********************************************
            try
            {
                //int a = int.Parse("test");
                int a = int.Parse("-22222222222");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş bir değer giriniz");
                Console.WriteLine(ex);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Veritipi Uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük ve ya çok büyük değer");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem Başarı ile tamamlandı");
            }


        }
    }
}