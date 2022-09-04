
Console.Write("Oyunu başlatmak için herhangi bir tuşa basınız Çıkış İçin (q): ");
string giris = Console.ReadLine();
double KazanmaSayisi = 0;
double KaybetmeSayisi = 0;

while (giris != "q")
{
    Console.WriteLine();
    double YanlisSayisi = 2;

    string[] isimler = new string[10]
    {
     "deve",
     "çilek",
     "otobüs",
     "mustafa",
     "işlemci",
     "bisiklet",
     "zeynep",
     "hasan",
     "futbol",
     "beyza"
    };

    string[] ipucu = new string[10]
    {
     "deve: Genelde Çöl de yaşarlar   ",
     "çilek: Meyve",
     "otobüs: Toplu taşıma aracı",
     "mustafa: Erkek ismi",
     "işlemci: Bilgisayar Parçası",
     "bisiklet: iki tekerlekli",
     "zeynep: Kız ismi",
     "hasan: Erkek ismi",
     "futbol: 22 kişi ile ve top ile oynanan oyun ",
     "beyza: Kız ismi "
    };

    Random rastgele = new Random();
    int isimsecme = rastgele.Next(0, isimler.Length);
    string secilenisim = isimler[isimsecme];

    int KarakterSecme = 0;
    int KarakterSecme2 = 0;
    Random rastgele1 = new Random();

    //Console.WriteLine(secilenisim[KarakterSecme]);
    for (int i = 0; i < 1; i++)
    {
        KarakterSecme = rastgele1.Next(0, secilenisim.Length);
        KarakterSecme2 = rastgele1.Next(0, secilenisim.Length);

        if (KarakterSecme == KarakterSecme2)
        {
            i--;
        }
    }

    for (int j = 0; j < ipucu.Length; j++)
    {
        if (ipucu[j].StartsWith(secilenisim))
        {
            int ipucuIndex = ipucu[j].IndexOf(":");
            ipucu[j] = ipucu[j].Substring(ipucuIndex + 1);
            Console.WriteLine("İpucu: " + ipucu[j]);
            break;
        }
    }

    while (giris != "q")
    {

        for (int i = 0; i < secilenisim.Length; i++)
        {

            if (i == KarakterSecme)
            {

                Console.Write(secilenisim[i]);
            }
            else if (i == KarakterSecme2)
            {
                Console.Write(secilenisim[i]);
            }
            else
            {
                Console.Write("*");
            }

        }



        Console.WriteLine();

        Console.WriteLine(" çıkış için (q) Tahmin için tahmin ettiğiniz ismi giriniz");
        giris = Console.ReadLine();

        if (giris == secilenisim)
        {
            Console.WriteLine("Tebrikler Bildiniz");
            KazanmaSayisi++;
            break;
        }

        if (YanlisSayisi > 0 && giris != "q")
        {
            Console.WriteLine("Bilemediniz Kalan hakkınız: " + " " + YanlisSayisi);
            YanlisSayisi--;

        }
        else if (giris != "q")
        {
            KaybetmeSayisi++;
            Console.WriteLine("Kaybettiniz");
            Console.Write("Oyunu başlatmak için herhangi bir tuşa basınız q(Çıkış): ");
            giris = Console.ReadLine();
            break;
        }

    }

}

Console.WriteLine("Bilme Sayısı: " + " " + KazanmaSayisi);
Console.WriteLine("Kaybetme Sayısı: " + " " + KaybetmeSayisi);

