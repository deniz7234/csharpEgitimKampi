using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler
            //Console.WriteLine("*****Fiyat Listesi*****");
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("----Elma Birim Fiyatı:" + applePrice + " TL");
            //Console.WriteLine("----Portakal Birim Fiyatı:" + orangePrice + " TL");
            //Console.WriteLine("----Çilek Birim Fiyatı:" + strawberryPrice + " TL");
            //Console.WriteLine("----patates Birim Fiyatı:" + potatoPrice + " TL");
            //Console.WriteLine("----domates Birim Fiyatı:" + tomatoPrice + " TL");
            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;
            //double totalapplePrice, totalorangePrice, totalstrawberryPrice, totalpotatoPrice, totaltomatoPrice;
            //totalapplePrice = appleGram * applePrice;
            //totalorangePrice = orangeGram * orangePrice;
            //totalstrawberryPrice = strawberryPrice * strawGram;
            //totalpotatoPrice=potatoPrice * potatoGram;
            //totaltomatoPrice=tomatoPrice* tomatoGram;
            //Console.WriteLine("Toplam Elmanın fiyatı:" + totalapplePrice);
            //Console.WriteLine("Alınan urun:" + " Elma -" + "Birim Fiyat:" + applePrice + "- Gramaj: " + appleGram + "- tutar:" + totalapplePrice);
            //Console.WriteLine("Alınan urun:" + " portakal -" + "Birim Fiyat:" + orangePrice + "- Gramaj: " + orangeGram + "- tutar:" + totalorangePrice);
            //Console.WriteLine("Alınan urun:" + " Çilek -" + "Birim Fiyat:" + strawberryPrice + "- Gramaj: " + strawGram + "- tutar:" + totalstrawberryPrice);
            //Console.WriteLine("Alınan urun:" + " Patates -" + "Birim Fiyat:" + potatoPrice + "- Gramaj: " + potatoGram + "- tutar:" + totalpotatoPrice);
            //Console.WriteLine("Alınan urun:" + " Domates -" + "Birim Fiyat:" + tomatoPrice + "- Gramaj: " + tomatoGram + "- tutar:" + totaltomatoPrice);
            //double shoppingtotalPrice=totalapplePrice+totalorangePrice+totaltomatoPrice+totalpotatoPrice+totalstrawberryPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("alınan toplam tutar:" + shoppingtotalPrice);
            //Console.Read();


            #endregion
            #region Char Degiskenler
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);



            #endregion
            #region Klavyeden veri girişi

            //Console.WriteLine("*****c# Yolcu Bilgileri****");
            //string passengerName, passengerSurName, passengerAge, passengerDistrict, passengerCity, passengerIdentityNumber;

            //Console.Write("Yolcu Adi:");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı:");
            //passengerSurName = Console.ReadLine();
            //Console.Write("il:");
            //passengerCity = Console.ReadLine();
            //Console.Write("ilçe Bilgisi:");
            //Console.Write("Yas:");
            //passengerDistrict = Console.ReadLine();
            //passengerAge = Console.ReadLine();

            //Console.Write("TC Kimlik Numarasi:");
            //passengerIdentityNumber= Console.ReadLine();



            //Console.WriteLine("-------------------------");

            //Console.WriteLine("Yolcu Bilgileri:" + passengerName + " " + passengerSurName+" "+passengerDistrict+" /"+passengerCity+" "+passengerAge+" "+passengerIdentityNumber);
            //Console.Read();
            #endregion
            #region Klavye int veri girişi ve donusumu
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice=20000;
            //chairPrice = 5000;
            //tvPrice = 12000;
            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen alacaginiz ayakkabı sayısını Giriniz:");
            //shoesCount=int.Parse(Console.ReadLine());
            //Console.Write("Lutfen alacaginiz Bilgisayar sayısını giriniz:");
            //computerCount=int.Parse(Console.ReadLine());
            //Console.Write("Lütfen alacaginiz Sandalye sayısını giriniz:");
            //chairCount=int.Parse(Console.ReadLine());
            //Console.Write("Lutfen alacaginiz Televizyon sayasını giriniz:");
            //tvCount=int.Parse(Console.ReadLine());

            //int totalPrice = (shoesCount * shoesPrice) + (computerCount * computerPrice) + (chairCount * chairPrice) + (tvCount * tvPrice);
            //Console.WriteLine("alinan toplam urun:" + totalPrice);
            //Console.Read();




            #endregion
            #region Double Değişken

            //double exam1, exam2, exam3, result;
            //Console.Write("Lutfen 1.sınavi giriniz:");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("Lutfen 2.sinavi giriniz:");
            //exam2 =double.Parse(Console.ReadLine());
            //Console.Write("Lutfen 3.sinavi Giriniz:");
            //exam3 =double.Parse(Console.ReadLine());
            //result=(exam1 + exam2+exam3)/3;
            //Console.WriteLine("sonuc: " + result);
            //Console.Read();



            #endregion
            #region Char klavye
            char gender;
            Console.Write("Cinsiyet:");
            gender=char.Parse(Console.ReadLine());
            Console.WriteLine("Cinsiyetiniz:" + gender);
            Console.Read();

            #endregion
        }
    } 
}
