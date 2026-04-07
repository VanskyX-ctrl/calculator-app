// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("==================");
Console.WriteLine("Pilih Angka 1-4: ");
Console.WriteLine("------------------");
Console.WriteLine("1. Penjumlahan");
Console.WriteLine("2. Pengurangan");
Console.WriteLine("3. Perkalian");
Console.WriteLine("4. Pembagian");
Console.WriteLine("==================");
int p = int.Parse(Console.ReadLine()!);
Console.WriteLine("Masukan Angka Pertama: ");
int var1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Masukan Ankga Kedua: ");
int var2 = int.Parse(Console.ReadLine()!);
if (p == 1)
{
    Console.WriteLine("Hasil: " + (var1 + var2));
}
else if (p == 2)
{
    Console.WriteLine("Hasil: " + (var1 - var2));
}
else if (p == 3)
{
    Console.WriteLine("Hasil: " + (var1 * var2));
}
else if (p == 4)
{
    Console.WriteLine("Hasil: " + (var1 / var2));
}
