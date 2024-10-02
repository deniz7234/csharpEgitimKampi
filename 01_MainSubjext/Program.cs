using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjext
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.Write("merhaba dunya");
            //Console.WriteLine("selam");
            //Console.WriteLine("*****Yemek Kategori*****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soguk Başlangıclar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-içecekler");
            //Console.WriteLine();
            //Console.WriteLine("*****Yemek Kategori*****");

            #endregion
            #region String Değişkenler
            //string customerName;
            //string customerSurName;
            //string customerPhone;
            //string customerEmail,district,city;
            //customerName = "Ali";
            //customerSurName = "Çınar";
            //customerPhone = "+90 500 400 3020";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıkoy";
            //city = "İstanbul";
            //Console.WriteLine("****Rezervasyon Kartı****");         
            //Console.WriteLine("---------------------------------");

            //Console.WriteLine("Müsteri:"+ customerName+ " "+customerSurName);
            //Console.WriteLine("İletisim:"+customerPhone);
            //Console.WriteLine("Email:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("---------------------------------");
            //customerName = "AyseGul";
            //customerSurName = "Kaya";
            //customerPhone = "+90 400 300 30 70";
            //customerEmail = "test@gmail.com";
            //district = "sapanca";
            //city = "Sakarya";  
            //Console.WriteLine("---------------------------------");

            //Console.WriteLine("Müsteri:" + customerName + " " + customerSurName);
            //Console.WriteLine("İletisim:" + customerPhone);
            //Console.WriteLine("Email:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("---------------------------------");

            #endregion
            #region int Degiskenler
            Console.WriteLine("**** Menu Fiyat****");
            Console.WriteLine();
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 200;
            int lemonadePrice = 30;
            Console.WriteLine("----hamburger:"+hamburgerPrice+"TL");
            Console.WriteLine("----Pizza:"+pizzaPrice + "TL");
            Console.WriteLine("----Kola:"+cokePrice + "TL");
            Console.WriteLine("----Limonata:"+lemonadePrice + "TL");
            Console.WriteLine("----Su:"+waterPrice + "TL");
            Console.WriteLine("----Kızartma:"+friesPrice + "TL");
            Console.WriteLine("**** Menu Fiyat****");
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;
            Console.WriteLine("-------------------------");
            hamburgerCount = 3;
            cokeCount=3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;
            int totalhamburgerPrice;
            int totalcokePrice;
            int totalwaterPrice;
            int totalfriesPrice;
            int totalpizzaPrice;
            int totallemonadePrice;
            totalhamburgerPrice = hamburgerPrice * hamburgerCount;
            totalcokePrice = cokePrice * cokeCount;
            totalwaterPrice = waterPrice * waterCount;
            totalfriesPrice = friesPrice * friesCount;
            totalpizzaPrice = pizzaPrice * pizzaCount;
            totallemonadePrice = lemonadePrice * lemonadeCount;
            Console.WriteLine("hamburger tutar:" +totalhamburgerPrice+" TL");
            Console.WriteLine("kola tutar:" +totalcokePrice+" TL");
            Console.WriteLine("su tutar:" +totalwaterPrice+" TL");
            Console.WriteLine("pizza tutar:" +totalpizzaPrice+" TL");
            Console.WriteLine("Limonata tutar:" +totallemonadePrice+" TL");
            Console.WriteLine("kızartma tutar:" +totalfriesPrice+" TL");

            Console.WriteLine("--------------------------------------"); ;
            int totalPrice=totalhamburgerPrice+totalcokePrice+totalwaterPrice+totalpizzaPrice+totalfriesPrice+totallemonadePrice;
            #endregion
            Console.WriteLine("Toplam odenecek Tutar:" + totalPrice + " TL");

            Console.Read();
            
        }
    }
}
