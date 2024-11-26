using System;

enum HavaDurumu
{
    Sunny,
    Rainy,
    Cloudy,
    Stormy
}

class HavaTahmini
{
    public string TavsiyeVer(HavaDurumu durum)
    {
        switch (durum)
        {
            case HavaDurumu.Sunny:
                return "Hava güzel, dışarıda keyif yapabilirsiniz.";
            case HavaDurumu.Rainy:
                return "Şemsiye almayı unutmayın.";
            case HavaDurumu.Cloudy:
                return "Hava bulutlu, yağmur ihtimaline karşı hazırlıklı olun.";
            case HavaDurumu.Stormy:
                return "Fırtına var, mümkünse dışarı çıkmayın.";
            default:
                return "Geçersiz hava durumu.";
        }
    }

    static void Main(string[] args)
    {
        HavaTahmini tahmin = new HavaTahmini();

        Console.WriteLine(tahmin.TavsiyeVer(HavaDurumu.Sunny));
        Console.WriteLine(tahmin.TavsiyeVer(HavaDurumu.Rainy));
        Console.WriteLine(tahmin.TavsiyeVer(HavaDurumu.Cloudy));
        Console.WriteLine(tahmin.TavsiyeVer(HavaDurumu.Stormy));
    }
}
