using System.Text;

namespace nepesseg
{
    class Program
    {
        static void Main(string[] args)
        {
            var orszagok = new List<Orszag>();

            using StreamReader sr = new(@"..\..\..\src\adatok-utf8.txt", Encoding.UTF8);

            _ = sr.ReadLine();

            while (!sr.EndOfStream)
            {
                orszagok.Add(new(sr.ReadLine()));
            }

            Console.WriteLine("4. feladat");
            Console.WriteLine($"A beolvasott országok száma {orszagok.Count}.\n");

            Console.WriteLine("5. feladat");

            Orszag kina = orszagok.Single(o => o.Orszagnev == "Kína");

            Console.WriteLine($"Kína népsűrűsége {kina.Nepsuruseg} fő/km^2.");

            Console.WriteLine("6. feladat");

            Orszag india = orszagok.Single(o => o.Orszagnev == "India");

            int nepessegKulonbseg = kina.Nepesseg - india.Nepesseg;

            Console.WriteLine($"Kínában a lakosság {nepessegKulonbseg} fővel volt több.");

            Console.WriteLine("7. feladat");

            var harmadikLegnepesebb = orszagok.OrderByDescending(o => o.Nepesseg).ElementAt(2);

            Console.WriteLine($"A harmadik legnépesebb ország: {harmadikLegnepesebb.Orszagnev}, a lakosság {harmadikLegnepesebb.Nepesseg} fő");

            Console.WriteLine("8. feladat - A következő országok lakosságának több mint 30%-a a fővárosban lakik:");

            var fovarosbanKoncentraltak = orszagok.Where(o => o.FovarosbanKoncentralt).ToList();

            foreach (var f in fovarosbanKoncentraltak)
            {
                Console.WriteLine($"\t{f.Orszagnev} ({f.Fovaros})");
            }

            Console.ReadKey();
        }
    }
}