using System.Net.Http.Headers;
Console.WriteLine("Konsol ekranına 10 kere... yazdırınız.");
for (int i = 1; i <=10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

Console.WriteLine("------1. Kısım bitti.------");

Console.WriteLine("1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");

for (int i = 2; i <20; i++)
{
    Console.WriteLine(i);
}


Console.WriteLine("-----2. Kısım Bitti.-------");

Console.WriteLine("1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");

for (int i = 1; i <=20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("-----3. Kısım Bitti.-------");

Console.WriteLine("50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");

int toplam = 0;
for (int i = 50; i <= 150; i++)
{
    toplam += i;
    Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {toplam}");
}

Console.WriteLine("-------4.Kısım bitti.------");

Console.WriteLine("1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.");

int tekToplam = 0;
int ciftToplam = 0;
for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)
    {
        ciftToplam += i;
    }
    else
    {
        tekToplam += i;
    }
}
Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {ciftToplam}");
Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {tekToplam}");

Console.WriteLine("-------5.Kısım bitti.------");
