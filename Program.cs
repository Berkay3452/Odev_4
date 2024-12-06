using System;
using System.Collections.Generic;

/*
 
class Program
{
    public static double ÜçgenAlanıHesapla()
    {
        double taban, yükseklik;

        Console.Write("Üçgenin tabanını giriniz: ");
        taban = Convert.ToDouble(Console.ReadLine());

        Console.Write("Üçgenin yüksekliğini giriniz: ");
        yükseklik = Convert.ToDouble(Console.ReadLine());

        double alan = (taban * yükseklik) / 2;
        return alan;
    }
    public static void Main()
    {
        Console.WriteLine("Soru 1: Matematiksel Hesaplama Yapan Parametresiz ve Geriye Değer Döndüren Metot");
        Console.WriteLine("---------------------------------------------------------------------------------");

        double alan = ÜçgenAlanıHesapla();
        Console.WriteLine("Hesaplanan üçgenin alanı: " + alan);
    }
}

*/






/*
 
class Program
{
    static void Main()
    {
        Console.WriteLine("Soru 2: Dizideki En Büyük Değeri Bulan Parametreli ve Geriye Değer Döndüren Metot");
        Console.WriteLine("----------------------------------------------------------------------------------");

        int[] numbers = { 3, 7, 2, 9, 5 };
        int max = FindMaxValue(numbers);
        Console.WriteLine("En büyük değer: " + max);
    }

    static int FindMaxValue(int[] array)
    {
        int maxValue = array[0];
        foreach (int number in array)
        {
            if (number > maxValue)
            {
                maxValue = number;
            }
        }
        return maxValue;
    }
}

*/





/*
 
class Program
{
    static void Main()
    {
        Console.WriteLine("Soru 3: Aşırı Yüklenmiş (Overloaded) Metot ile Farklı Türdeki Verilerin Toplamını Bulma");
        Console.WriteLine("----------------------------------------------------------------------------------------");

        Console.WriteLine("İki int sayının toplamı: " + CalculateSum(5, 8));
        Console.WriteLine("İki double sayının toplamı: " + CalculateSum(3.5, 7.2));
        Console.WriteLine("Üç int sayının toplamı: " + CalculateSum(4, 9, 2));
    }

    static int CalculateSum(int a, int b)
    {
        return a + b;
    }

    static double CalculateSum(double a, double b)
    {
        return a + b;
    }

    static int CalculateSum(int a, int b, int c)
    {
        return a + b + c;
    }
}

*/




/*
 
class Program
{
    static void Main()
    {
        Console.WriteLine("Soru 4: Recursive Metot ile Fibonacci Dizisi Hesaplama");
        Console.WriteLine("-------------------------------------------------------");

        int n = 5;
        Console.WriteLine($"{n}. Fibonacci sayısı: {Fibonacci(n)}");
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

*/




/*
 
class Program
{
    static void Main()
    {
        Console.WriteLine("Soru 5: Params ile Sınırsız Sayıda Parametre Alarak Ortalama Hesaplama");
        Console.WriteLine("-----------------------------------------------------------------------");

        double average1 = CalculateAverage(3.5, 7.2, 5.0, 8.8);
        Console.WriteLine("Ortalama: " + average1);

        double average2 = CalculateAverage(10.0, 20.0);
        Console.WriteLine("Ortalama: " + average2);

        double average3 = CalculateAverage();
        Console.WriteLine("Ortalama: " + average3);
    }

    static double CalculateAverage(params double[] numbers)
    {
        if (numbers.Length == 0)
            return 0;

        double sum = 0;
        foreach (double number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Length;
    }
}

*/




/*
 
class Program
{
    static void Main()
    {
        Console.WriteLine("Soru 6: Dizi Elemanlarını Toplayan ve Filtreleme Şartı Ekleyen Metot");
        Console.WriteLine("---------------------------------------------------------------------");

        int[] numbers = { 3, 7, 2, 9, 5, 12, 4 };
        int filterValue = 5;
        int sum = SumFilteredElements(numbers, filterValue);
        Console.WriteLine($"Filtre değeri {filterValue}'den büyük olan elemanların toplamı: {sum}");
    }

    static int SumFilteredElements(int[] array, int filter)
    {
        int sum = 0;
        foreach (int number in array)
        {
            if (number > filter)
            {
                sum += number;
            }
        }
        return sum;
    }
}

*/




/*
 
class Program
{
    static void Main()
    {
        Console.WriteLine("Soru 7: Seçmeli (Optional) Parametre ile Belirli Yaştan Sonraki Yılları Sayma");
        Console.WriteLine("------------------------------------------------------------------------------");

        Console.WriteLine("Belirtilen yaş 25: " + CalculateYearsAfter18(25));
        Console.WriteLine("Yaş belirtilmedi (varsayılan 18): " + CalculateYearsAfter18());
        Console.WriteLine("Belirtilen yaş 30: " + CalculateYearsAfter18(30));
    }

    static int CalculateYearsAfter18(int age = 18)
    {
        return age > 18 ? age - 18 : 0;
    }
}

*/






/*
 
class Program
{
    static void Main()
    {
        Console.WriteLine("Soru 8: Geriye Koleksiyon Döndüren ve Veriyi Filtreleyen Metot");
        Console.WriteLine("---------------------------------------------------------------");

        string[] words = { "elma", "armut", "karpuz", "çilek", "muz", "kayısı" };
        List<string> filteredWords = FilterLongWords(words);

        Console.WriteLine("5 karakterden uzun kelimeler:");
        foreach (string word in filteredWords)
        {
            Console.WriteLine(word);
        }
    }

    static List<string> FilterLongWords(string[] array)
    {
        List<string> result = new List<string>();
        foreach (string word in array)
        {
            if (word.Length > 5)
            {
                result.Add(word);
            }
        }
        return result;
    }
}

*/

