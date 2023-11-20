using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penilaian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string predikat;

            Console.Write("nama : ");
            string nama = Console.ReadLine();
            Console.Write("nilai harian : ");
            int nilai_harian = Convert.ToInt32(Console.ReadLine());
            Console.Write("nilai uts : ");
            int nilai_uts= Convert.ToInt32(Console.ReadLine());
            Console.Write("nilai uas : ");
            int nilai_uas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("nama : " + nama);
            Console.WriteLine("nilai harian : " + nilai_harian);
            Console.WriteLine("nilai uts : " + nilai_uts);
            Console.WriteLine("nilai uas : " + nilai_uas);

            int nilai_rata = (nilai_harian + nilai_uts + nilai_uas) / 3;
            Console.WriteLine("nilai_rata : " + nilai_rata);

            if (nilai_rata > 80)
            {
                predikat = "A";
                Console.WriteLine("predikat: " + predikat);
            }
            else if (nilai_rata >= 70 && nilai_rata <= 60)
            {
                predikat = "B";
                Console.WriteLine("predikat: " + predikat);
            }
            else if (nilai_rata >= 60 && nilai_rata <= 70)
            {
                predikat = "C";
                Console.WriteLine("predikat: " + predikat);
            }
            else if (nilai_rata >= 50 && nilai_rata <= 60)
            {
                predikat = "D";
                Console.WriteLine("predikat: " + predikat);
            }
            else if (nilai_rata <= 50)
            {
                predikat = "E";
                Console.WriteLine("predikat: " + predikat);
            }
            Console.ReadKey();
        }
    }
}