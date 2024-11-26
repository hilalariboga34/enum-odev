using System;

enum TrafikIsigi
{
    Red,
    Yellow,
    Green
}

class TrafikKontrol
{
    public string DurumBelirle(TrafikIsigi durum)
    {
        switch (durum)
        {
            case TrafikIsigi.Red:
                return "Dur! Bekle.";
            case TrafikIsigi.Yellow:
                return "Hazır ol. Geçmeye hazırlan.";
            case TrafikIsigi.Green:
                return "Geçebilirsin.";
            default:
                return "Geçersiz trafik ışığı durumu.";
        }
    }

    static void Main(string[] args)
    {
        TrafikKontrol kontrol = new TrafikKontrol();

        Console.WriteLine(kontrol.DurumBelirle(TrafikIsigi.Red));
        Console.WriteLine(kontrol.DurumBelirle(TrafikIsigi.Yellow));
        Console.WriteLine(kontrol.DurumBelirle(TrafikIsigi.Green));
    }
}
