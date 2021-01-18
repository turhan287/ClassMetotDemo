using System;

namespace Odev3_Gun
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Jony BLACK";
            musteri1.IbanNum = "TR01 0742 2001 0000 0062 4742 12";
            musteri1.AccountNum = "6247 4212";
            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Silvia PARTNER";
            musteri2.IbanNum = "TR01 0742 2001 0000 0065 2542 02";
            musteri2.AccountNum = "6525 4202";        
            MusteriManager musteriManager = new MusteriManager();
            while (true)
            {
                Console.WriteLine("Seçim Yapınız 1-3");
                string choose = Console.ReadLine();
                if (choose == "1")
                {
                    musteriManager.Add(musteri1);
                    musteriManager.Add(musteri2);
                    break;
                }
                else if (choose == "2")
                {
                    musteriManager.Del(musteri1);
                    musteriManager.Del(musteri2);
                    break;
                }
                else if (choose == "3")
                {
                    musteriManager.Update(musteri1);
                    musteriManager.Update(musteri2);
                    break;
                }
               


            }
            

        }
    }
}
