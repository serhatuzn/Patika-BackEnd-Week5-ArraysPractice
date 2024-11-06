int[] sayilar = new int[10]; // 1. Adım: 1-10 adet tam sayı verisi alacak bir dizi tanımlayınız.

for (int i = 0; i < sayilar.Length; i++)
{
    Console.Write($"Lütfen {i + 1}. sayi giriniz : ");
    sayilar[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\r\n********************************");
{
    foreach (int j in sayilar) // Dizi elemanlarını foreach döngüsü ile ekrana yazdırıyoruz.
    {
        Console.WriteLine($"Girilen Sayılar ==> {j} ");
    }
}

Console.WriteLine("\r\n********************************");

// Kullanıcıdan 11. sayıyı alıyoruz.
Console.Write("Lütfen 11. Sayıyı siz giriniz : ");
int yenisayi = int.Parse(Console.ReadLine());

// 11 elemanlı yeni bir dizi oluşturup eski elemanları ve yeni sayıyı ekliyoruz.
int[] yeniDizi = new int[11];
for (int i = 0; i < sayilar.Length; i++)
{
    yeniDizi[i] = sayilar[i];
}
yeniDizi[10] = yenisayi;

 // Büyükten küçüğe sıralama
Array.Sort(yeniDizi);
Array.Reverse(yeniDizi);

// yeni diziyi ekrana yazdırma
Console.WriteLine("\r\nEklenmiş Sayıyla Büyükten küçüğe sıralanan sayılar : ");
foreach (int j in yeniDizi)
{
    Console.WriteLine($"Girilen Sayılar ==> {j} ");
}