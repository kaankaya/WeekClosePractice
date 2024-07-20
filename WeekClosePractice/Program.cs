using System;

namespace WeekClose
{
    class Program
    {
        static void Main(string[] args) 
        {
            /*
             1 - Aşağıdaki çıktıyı yazan bir program.

            Merhaba
            Nasılsın ?
            İyiyim
            Sen nasılsın ?
             */
            Console.WriteLine("--------Uygulama 1 ---------");
            Console.WriteLine("Merhaba");
            Console.WriteLine("Nasılsın ?");
            Console.WriteLine("İyiyim");
            Console.WriteLine("Sen nasılsın?");
            /*
             2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız
             */
            Console.WriteLine("--------Uygulama 2 ---------");
            string str = "Metinsel Değer";
            int integerData = 5;
            Console.WriteLine($"String İfade: {str}");
            Console.WriteLine($"Tam sayı değer: {integerData}");
            /*
             3 - Rastgele bir sayı üretip , ekrana yazdırınız.
             */
            Console.WriteLine("--------Uygulama 3 ---------");
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 50);
            Console.WriteLine($"Rastgele Sayı: {randomNumber} ");
            /*
             4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
             */
            Console.WriteLine("--------Uygulama 4 ---------");
            Random rnde = new Random();
            int remaining = rnde.Next(1, 50);
            int remainingNumber = remaining % 3;
            Console.WriteLine($" {remaining} sayısının 3 e bölümünden kalan sayı : {remainingNumber}");
            /*
             5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
             */
            Console.WriteLine("--------Uygulama 5 ---------");
            Console.WriteLine("Lütfen Yaşınızı Giriniz");
            int age;
            //yaş değerini tryparse ile kontrol edip kullanıcı metinsel değer girerse program exception atmaması adına kontrol sağlıyoruz.
            //eğer veri doğru ise işlemi gerçekleştiriyoruz
            bool result = int.TryParse(Console.ReadLine(), out age);
            if (result)
            {
                if (age > 18)
                {
                    Console.WriteLine(" + ");
                }
                else
                {
                    Console.WriteLine(" - ");
                }
            }
            else
            {
                Console.WriteLine("Yanlış Yaş Değeri Girdiniz");

            }
            /*
             6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
             */
            Console.WriteLine("--------Uygulama 6 ---------");
            //for döngüsü ile i 10 dan küçük oluncaya kadar dön
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem");
            }
            /*
             7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
             */
            Console.WriteLine("--------Uygulama 7 ---------");
            Console.WriteLine("Girilecek Değer (Gülse Birsel) ");
            string valueGulse = Console.ReadLine();
            Console.WriteLine("Girilecek Değer (Demet Evgar) ");
            string valueDemet = Console.ReadLine();
            //yeni bir değer oluşturuyorum gulse değerini ona atıyorum
            string newValue = valueGulse;
            //gulse değerine demetin değerini atıyorum
            valueGulse = valueDemet;
            //demetin in değerinde gulsenin en baştaki değerini atıyorum
            valueDemet = newValue;
            Console.WriteLine($" Value Gulseninin yeni değeri: {valueGulse} -- Value Demetin Yeni Değeri: {valueDemet} ");

            Console.WriteLine("--------Uygulama 8 ---------");
            /*
             * 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
             */
            //Değer dönüşü olmayan bir method tanımlama void
            static void BenDegerDondurmem()
            {
                Console.WriteLine("Ben Değer Döndürmem ,benim bir karşılığım yok, beni değişkene atamaya çalışma");
            }
            //tanımlanan methodu çalıştır
            BenDegerDondurmem();

            Console.WriteLine("--------Uygulama 9 ---------");
            /*
             9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
             */
            //total value methoduna erişmek için program classımı tanımlıyorum çünkü kullanacağım method için static bir method içi
            Program program = new Program();
            int toplam = program.TotalValue(5, 10);
            Console.WriteLine($"Girilen iki sayının toplam değerini yazan method sonucu {toplam} ");

            Console.WriteLine("--------Uygulama 10 ---------");
            /*
             10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
             */
            //Method tanımı ismi UserResponseValue olarak tanımlanmıştır

            Console.WriteLine("--------Uygulama 11 ---------");
            /*
             *  11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
             */
            Console.WriteLine("1. kişini yaşını giriniz");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. kişini yaşını giriniz");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. kişini yaşını giriniz");
            int age3 = Convert.ToInt32(Console.ReadLine());

            int ageMax = program.MaxAge(age1, age2, age3);
            Console.WriteLine($"En Büyük Yaş Değeri {ageMax}");

            Console.WriteLine("--------Uygulama 12 ---------");
            /*
             12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
             */

            int maxNumber = program.GetNumberPerson();
            Console.WriteLine($"Girilen sayılar arasındaki en büyük sayı {maxNumber}");

            Console.WriteLine("--------Uygulama 13 ---------");
            /*
             13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
             */
            Console.WriteLine("İlk İsimi giriniz");
            string name1 = Console.ReadLine();
            Console.WriteLine("İkinci İsmi Giriniz");
            string name2 = Console.ReadLine();

            Program.ChangeValueName(ref name1, ref name2);
            Console.WriteLine($"İlk girilen değer {name1}");
            Console.WriteLine($"İkinci Girilen değer {name2}");

            Console.WriteLine("--------Uygulama 14 ---------");
            /*
             14- Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
             */
            Console.WriteLine("Sayı giriniz");
            int sayiTekCift = Convert.ToInt32(Console.ReadLine());
            program.OddEvenNumber(sayiTekCift);

            Console.WriteLine("--------Uygulama 15 ---------");
            /*
             15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
             */
            Console.WriteLine("Lütfen Hızınızı Giriniz");
            int speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Yolculuk saatinizi Giriniz");
            int time = Convert.ToInt32(Console.ReadLine());
            int dist = program.CalculateDist(speed, time);
            Console.WriteLine($"Gidilen Km {dist} ");

            Console.WriteLine("--------Uygulama 16 ---------");
            /*
             16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
             */
            Console.WriteLine("Yarıçap Giriniz");
            double radius = Convert.ToDouble(Console.ReadLine());
            program.CalculateCircle(radius);
            Console.WriteLine($"Dairenin Yarıçapı {radius}");

            Console.WriteLine("--------Uygulama 17 ---------");
            /*
             17 -"Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
             */
            string toLower = "Zaman bir GeRi SayIm";
            string toUpper = "Zaman bir GeRi SayIm";
            Console.WriteLine($"Hepsi küçük {toLower.ToLower()}");
            Console.WriteLine($"Hepsi Büyük {toLower.ToUpper()}");

            Console.WriteLine("--------Uygulama 18 ---------");
            /*
             18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
             */
            string clean = "  Selamlar  ";
            Console.WriteLine($"Boşluk Temiz Hali {clean.Trim()}");



        }//End MAİN METHOD

        //Uygulama 9 Method Tanımı
        public int TotalValue(int a, int b)
        {
            return a + b;
        }//End totalValue Method

        //Uygulama 10 method tanımı
        public string UserResponseValue(bool input)
        {
            if (input) 
            {
                return "Doğru";
            }
            else
            {
                return "False";
            }
        }//End UserResponseValue Method

        //uygulama 11 method tanımı
        public int MaxAge(int person1,int person2,int person3)
        {
            //Math.Max methodu maksimum 2 argümen kabul ediyor ama burada math.max ı iki kere çağırak bu sorunu çözmüş oluyoruz
            int AgePerson = Math.Max(person1,Math.Max(person2,person3));
            return AgePerson;
        }//End MaxAge Methodu

        //Uygulama 12 Method Tanımı
        public int GetNumberPerson() 
        {
            //Kullanıcıdan sınırsız sayıda veri alacağımız için bir liste oluşturuyoruz
            List<int> list = new List<int>();
            //kullanıcıdan veri girişi alıyoruz
            string NumberValue;
            Console.WriteLine("Girmek İstediğiniz sayıları lütfen sırasıyla giriniz. Sayı Girmeyi Bitirmek istediğinizde ekrana -> 'Bitir' yazmanız yeterli");
            //While döngüsünü aktif ediyoruz sınırsız sayıda dönmesi için eğer kullanıcı bitir diye girerse break ile döngü yü sonlandırıyoruz.ve daha sonra .max() methodu ile liste içerisindeki en büyük sayıyı buluyoruz
            while (true)
            {
                NumberValue = Console.ReadLine();
                if (NumberValue == "bitir")
                {
                    break;
                }

                int number;
                if(int.TryParse(NumberValue,out number))
                {
                    list.Add(number);
                }
                else
                {
                    Console.WriteLine("Lütfen Sayı Giriniz veya bitir yazarak programı sonlandırınız");
                }
            }//End While

            int maxNumber = list.Max();
            return maxNumber;
        }//End GetNumberPerson method
        
        //Uygulama 13 Method Tanımı
        //girilen değerlerin yerlerinin değişimi
        static void ChangeValueName(ref string val1,ref string val2)
        {
            string temp = val1;
            val1 = val2;

            val2 = temp;
        }//End ChangeValueName method

        //Uygulama 14 Method Tanısı
        //kullanıcıdan alınan sayının tek mi çift mi olduğunu kalana göre kontrol edilmesi
        public int OddEvenNumber(int oddeven)
        {
            if(oddeven % 2 == 0)
            {
                Console.WriteLine("Sayı çift");
            }
            else
            {
                Console.WriteLine("Sayı Tek");
            }
            return oddeven;
        }//End OddEvenNumber method

        //Uygulama 15 Method Tanısı
        public int CalculateDist(int speed, int time)
        {
            return speed * time;
        }

        //Uygulama 16 Method Tanısı
        public double CalculateCircle(double raidus)
        {
            // Yarıçap  hesaplama: π * r²
            return Math.PI * Math.Pow(raidus, 2);
        }
    }
}

