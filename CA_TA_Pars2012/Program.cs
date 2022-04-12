using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_TA_Pars2012
{
    class Program
    {
        static List<Versenyzo> versenyzok = new List<Versenyzo>();
        static void Main(string[] args)
        {
            Beolvas();
            F05();
            F06();
            F09();
            F10();
            Console.ReadKey();
        }

        private static void F10()
        {
            using (var sw = new StreamWriter(path: @"..\..\Resources\Dontos2012.txt", append: false, encoding: Encoding.UTF8))
            {
                var rendezettLista = versenyzok.OrderByDescending(x => x.Eredmeny).ToList();

                sw.WriteLine("Helyezés;Név;Csoport;Nemzet;NemzetKód;Sorozat;Eredmény");

                int helyezes = 1;
                for (int i = 0; i < 12; i++)
                {
                    sw.WriteLine($"{helyezes};{rendezettLista[i].Nev};{rendezettLista[i].Csoport},{rendezettLista[i].Nemzet};" +
                        $"{rendezettLista[i].Kod};{rendezettLista[i].Sorozat};{rendezettLista[i].Eredmeny}");
                    helyezes++;
                }
            }
        }

        private static void F09()
        {
            var legjobbAtleta = versenyzok.OrderByDescending(x => x.Eredmeny).First();
            Console.WriteLine($"9. Feladat: A selejtező nyertese:" +
                $"\n\tNév: {legjobbAtleta.Nev}" +
                $"\n\tCsoport: {legjobbAtleta.Csoport}" +
                $"\n\tNemzet: {legjobbAtleta.Nemzet}" +
                $"\n\tNemzet kód: {legjobbAtleta.Kod}" +
                $"\n\tSorozat: {legjobbAtleta.Sorozat}" +
                $"\n\tEredmény: {legjobbAtleta.Eredmeny}");
        }

        private static void F06()
        {
            var autoTovabbjutok = versenyzok.Count(x => x.Dobasok[0] > 78 || x.Dobasok[1] > 78);
            Console.WriteLine($"6. Feladat: 78,00 méter feletti eredménnyel továbbjutott: {autoTovabbjutok} fő");
        }

        private static void F05()
        {
            Console.WriteLine($"5. Feladat: Versenyzők száma a selejtezőkben: {versenyzok.Count} fő");
        }

        private static void Beolvas()
        {
            using (var sr = new StreamReader(path: @"..\..\Resources\Selejtezo2012.txt", encoding: Encoding.UTF8))
            {
                _ = sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    versenyzok.Add(new Versenyzo(sr.ReadLine()));
                }
            }
        }
    }
}
