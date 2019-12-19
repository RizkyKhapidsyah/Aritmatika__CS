using System;

namespace Aritmatika__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            String A, B;
            int C, D;

            Console.Write("Masukkan Angka Pertama  : "); C = Convert.ToInt32(A = Console.ReadLine()); //A = Console.ReadLine(); <- Metode Pembacaan Input jika Hanya String Saja
            Console.Write("Masukkan Angka Kedua    : "); D = Convert.ToInt32(B = Console.ReadLine()); //B = Console.ReadLine(); <- Metode Pembacaan Input jika Hanya String Saja
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Hasil Penggabungan (><) = {0}", A + B);
            Console.WriteLine("Hasil Penjumlahan   (+) = {0}", C + D);
            Console.WriteLine("Hasil Pembagian     (/) = {0}", C / D);
            Console.WriteLine("Hasil Perkalian     (x) = {0}", C * D);
            Console.WriteLine("Hasil Pengurangan   (-) = {0}", C - D);
            Console.WriteLine("Hasil Modulus       (%) = {0}", C % D);

            Console.ReadLine();
        }
    }
}
