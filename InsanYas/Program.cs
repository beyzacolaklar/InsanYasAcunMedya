// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        while (true) 
        {
            Console.Write("Lütfen yaşınızı girin (Çıkmak için -1 girin): ");
            int yas = Convert.ToInt32(Console.ReadLine());

            if (yas == -1) // Çıkış şartı
            {
                Console.WriteLine("Programdan çıkılıyor...");
                break;
            }

            Console.WriteLine(YasKategorisiBelirle(yas));
        }
    }

    static string YasKategorisiBelirle(int yas)
    {
        if (yas < 0 || yas > 99)
        {
            return "Ya hiç doğmadınız ya da çoktan öldünüz...";
        }
        else if (yas < 18)
        {
            return "Küçüksünüz";
        }
        else if (yas < 35)
        {
            return "Gençsiniz";
        }
        else if (yas < 55)
        {
            return "Yetişkinsiniz";
        }
        else if (yas < 75)
        {
            return "Yaşlısınız";
        }
        else
        {
            return "Çok yaşlısınız";
        }
    }
}

