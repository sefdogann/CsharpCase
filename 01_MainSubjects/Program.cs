using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WritleLine("Merhaba Dünya!");
            //Console.WriteLine("*****Yemek Katagorileri*****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana yemekler");
            //Console.WriteLine("3-Soğuk başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Katagorileri*****");
            //Console.Read();
            #endregion

            #region Değişkenler

            //string
            //Değişken_türü değişken adı;
            //string name;
            //name = "Murat";
            //Console.WriteLine(name);
            //string passengerName;
            //string passengerSurname;
            //string passengerPhone;
            //string passengerEmail, district, city;

            //passengerName = "Ali";
            //passengerSurname = "Çınar";
            //passengerPhone = "+90 500 400 30 20";
            //passengerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";


            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri :" + passengerName + " " + passengerSurname);
            //Console.WriteLine("İletişim :"+passengerPhone);
            //Console.WriteLine("Email adresi:" + passengerEmail);
            //Console.WriteLine("Adres : " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");

            //passengerName = "Sefer";
            //passengerSurname = "Dogan";
            //passengerPhone = "+ 90 500 500 500";
            //passengerEmail = "Test@gmail.com";
            //district = "Melikgazi";
            //city = "Kayseri";

            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri :" + passengerName + " " + passengerSurname);
            //Console.WriteLine("İletişim :" + passengerPhone);
            //Console.WriteLine("Email adresi:" + passengerEmail);
            //Console.WriteLine("Adres : " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");

            //Console.ReadLine();



            #endregion

            #region Int değişkenler

            //int 
            //int number =24;
            //Console.Writeline(number); 

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int LemonadePrice = 30;

            //Console.WriteLine("***** Restoran Menü Fiyatı*****");
            //Console.WriteLine();
            //Console.WriteLine("-----Hamburger:" + hamburgerPrice + " TL");
            //Console.WriteLine("-----Pizza:" + pizzaPrice + " TL");
            //Console.WriteLine("-----Kola:" + cokePrice + " TL");
            //Console.WriteLine("-----Limonata:" + LemonadePrice + " TL");
            //Console.WriteLine("-----Kızartma:" + friesPrice + " TL");
            //Console.WriteLine("-----Su:" + waterPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("***** Restoran Menü Fiyatı *****");
            //Console.WriteLine();
            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friesCount;
            //int pizzaCount;
            //int LemonadeCount;

            //int totalhamburgerPrice = 0;
            //int totalcokePrice = 0;
            //int totalwaterPrice = 0;
            //int totalfriesPrice = 0;
            //int totalpizzaPrice = 0;
            //int totalLemonadePrice = 0;


            //hamburgerCount = 3;
            //cokeCount=3;
            //waterCount=3;
            //friesCount=1;
            //pizzaCount=0;
            //LemonadeCount=0;

            //totalhamburgerPrice =hamburgerCount*hamburgerPrice;
            //totalcokePrice = cokeCount*cokePrice;
            //totalwaterPrice = waterCount*waterPrice;
            //totalfriesPrice=friesCount*friesPrice;
            //totalpizzaPrice = pizzaCount*pizzaPrice;
            //totalLemonadePrice = LemonadeCount * LemonadePrice;

            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Hamburger Tutarı : "+ totalhamburgerPrice);
            //Console.WriteLine("Kola tutarı :" +  totalcokePrice);
            //Console.WriteLine("Su tutarı : "+  totalwaterPrice);
            //Console.WriteLine("Kızartma tutarı : "+ totalfriesPrice);
            //Console.WriteLine("Pizza tutarı : " + totalpizzaPrice);
            //Console.WriteLine("Limonata tutarı :" + totalLemonadePrice);
            //Console.WriteLine("-----------------------------------------------");
            //int totalPrice = totalhamburgerPrice + totalcokePrice + totalwaterPrice + totalfriesPrice + totalpizzaPrice + totalLemonadePrice;
            //Console.WriteLine("Total tutar : " + totalPrice);


            #endregion

            #region DoubleDegiskenler
            //double number ;
            //number = 4.85;
            //Console.WriteLine(nummber);

            //Console.WriteLine("*****Fiyat Listesi*****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potato, tomato;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potato = 9.74;
            //tomato = 6.88;
            //Console.WriteLine("----Elma birim fiyatı:" + applePrice);
            //Console.WriteLine("----Portakal birim fiyatı:" +  orangePrice);
            //Console.WriteLine("----Çilek birim fiyatı:" +  strawberryPrice);
            //Console.WriteLine("----Patates birim fiyatı:"+ potato);
            //Console.WriteLine("----Domates birim fiyatı: "+  tomato);

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;
            //appleGram = 2.355;
            //orangeGram = 1.444;
            //strawGram = 1.555;
            //potatoGram = 1.899;
            //tomatoGram = 1.754;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawTotalPrice = strawGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potato;
            //double tomatoTotalPrice = tomatoGram * tomato;

            //Console.WriteLine("-Alınan Ürün : Elma - "+ "Birim Fiyat : "+ applePrice + " -Gramaj :"+ appleGram + " -Toplam tutar:"+  appleTotalPrice);

            //Console.WriteLine("-Alınan Ürün : portakal - " + "Birim Fiyat : " + orangePrice + " -Gramaj :" + orangeGram + " -Toplam tutar:" + orangeTotalPrice);

            //Console.WriteLine("-Alınan Ürün : çilek - " + "Birim Fiyat : " + strawberryPrice + " -Gramaj :" + strawGram + " -Toplam tutar:" + strawTotalPrice);

            //Console.WriteLine("-Alınan Ürün : patates - " + "Birim Fiyat : " + potato + " -Gramaj :" + potatoGram + " -Toplam tutar:" + potatoTotalPrice);

            //Console.WriteLine("-Alınan Ürün : Elma - " + "Birim Fiyat : " + tomato+ " -Gramaj :" + tomatoGram + " -Toplam tutar:" + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş tutarı :" + shoppingTotalPrice + "TL");





            #endregion

            #region CharDegiskenler
            //ABCDEFGH
            //DEF....
            //TOPLANTI SAAT 20.00'DE
            //"  '

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişi String Değişkenler

            //Console.WriteLine("**** Csharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adı: ");

            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu SoyAd : ");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine("İlçe Bilgisi: "  );
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine("Şehir Bilgisi : " );
            //passengerCity = Console.ReadLine();

            //Console.WriteLine("Yolcu Yaş : " );
            //passengerAge = Console.ReadLine();
            //Console.WriteLine("Yolcu TC Kimlik No : ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine("-------------------------------------");
            //Console.Write("Yolcu TC Kimlik No : " + passengerIdentityNumber + "-Yolcu Ad Soyad " + passengerName + " " + passengerSurname  + "  " + passengerAge + " " + passengerDistrict + "/ " + passengerCity);







            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            //ABC12D

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 1666;
            //chairPrice = 1522;
            //tvPrice = 1200;

            //int shoesCount,computerCount,chairCount,tvCount;

            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz : ");
            //shoesCount =int.Parse( Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz :");
            //computerCount =int.Parse( Console.ReadLine());
            //Console.WriteLine("Lütfen aldığınız sandalye sayısını giriniz :");
            //chairCount =int.Parse( Console.ReadLine());
            //Console.WriteLine("Lütfen aldığınız Televizyon sayısını giriniz :");
            //tvCount =int.Parse( Console.ReadLine());

            //int totalPrice =shoesCount*shoePrice + chairCount*chairPrice+tvCount*tvPrice + computerCount*computerPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar : "+ totalPrice);
            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Lütfen 1.Sınav Notunu Giriniz : ");
            //exam1 =double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.Sınav Notunu Giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3.Sınav Notunu Giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) /3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız : " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz : ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender);


            #endregion


            //Console.ReadLine();
        }
    }
}
