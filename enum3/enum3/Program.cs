using System;

enum CalisanRol
{
    Manager,
    Developer,
    Designer,
    Tester
}

class MaasHesaplama
{
    public double MaasHesapla(CalisanRol rol)
    {
        switch (rol)
        {
            case CalisanRol.Manager:
                return 15000.0;
            case CalisanRol.Developer:
                return 12000.0;
            case CalisanRol.Designer:
                return 10000.0;
            case CalisanRol.Tester:
                return 9000.0;
            default:
                throw new ArgumentException("Geçersiz çalışan rolü.");
        }
    }

    static void Main(string[] args)
    {
        MaasHesaplama hesaplama = new MaasHesaplama();

        Console.WriteLine($"Manager maaşı: {hesaplama.MaasHesapla(CalisanRol.Manager)} TL");
        Console.WriteLine($"Developer maaşı: {hesaplama.MaasHesapla(CalisanRol.Developer)} TL");
        Console.WriteLine($"Designer maaşı: {hesaplama.MaasHesapla(CalisanRol.Designer)} TL");
        Console.WriteLine($"Tester maaşı: {hesaplama.MaasHesapla(CalisanRol.Tester)} TL");
    }
}
