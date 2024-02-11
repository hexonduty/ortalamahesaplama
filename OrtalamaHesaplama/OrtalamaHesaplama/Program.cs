using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtalamaHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ortalama Hesaplama Uygulaması..");
            Console.WriteLine("Sisteme lütfen giriş yapınız.");
            string name = "admin";
            int pass = 123;

            Console.Write("Kullanıcı adınızı giriniz: ");
            string userName = Console.ReadLine();
            Console.Write("Şifrenizi giriniz: ");
            int userPass = Convert.ToInt32(Console.ReadLine());

            if (userName == name && userPass == pass) {
                Console.WriteLine("Giriş başarılı lütfen işleminize devam edin.");
            }
            else if (userName != name &&  userPass != pass)
            {
                Console.WriteLine("Lütfen Kullanıcı Adınızı ve Şifrenizi kontrol edin..");
            }
            else
            {
                return;
            }


            Console.Write("Kaç dersiniz var? : ");
            int dersSayisi = Convert.ToInt32(Console.ReadLine());

            double toplamNot = 0;

            for (int i = 0; i < dersSayisi; i++)
            {
                Console.Write($"Ders {i} adı: ");
                string dersAdi = (Console.ReadLine());

                Console.Write($"Ders {i} notu : ");
                double dersNotu = Convert.ToDouble(Console.ReadLine());

                toplamNot += dersNotu;
            }

            double ortalama = toplamNot / dersSayisi;

            Console.WriteLine($"Ders Notunuz : {ortalama}");
        }
    }
}
