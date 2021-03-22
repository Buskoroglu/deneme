using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnekk
{
    class Program
    {
        static void Main(string[] args)
        {

            bool yenidengirilecekmi = true;
            
            
            while(yenidengirilecekmi==true)
            {

                Console.WriteLine("Şifre giriniz : ");
                string şifre = Console.ReadLine();

                if (şifre.Length < 4 || şifre.Length > 25)
                {
                    Console.WriteLine("Şifre geçersiz, şifrenizin uzunluğu yanlış.");
                   yenidengirilecekmi = true;
                }

                else if (şifre.Contains("ç") || şifre.Contains("ş") || şifre.Contains("ı") || şifre.Contains("ğ") || şifre.Contains("ü") || şifre.Contains("ö"))
                {
                    Console.WriteLine("Şifre geçersiz,Türkçe karakter kullanmayınız.");
                   yenidengirilecekmi = true;
                }

                else if (şifre.Contains(" "))
                { 
                    Console.WriteLine("Şifre geçersiz, boşluk olmamasına dikkat edin.");
                    yenidengirilecekmi = true;
                }

                else
                {
                    Console.WriteLine("Şifre geçerli.");
                  yenidengirilecekmi = false;
                }
            }

            Console.ReadKey();

        }
    }
}
