using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace KandUzd_Klase
{
    public class Mokinys
    {
        private string _pavarde;
        public List<int> Pazymiai;
        public double Vidurkis;

        public string Pavarde
        {
            get { return _pavarde; }
            set { _pavarde = value; }
        }
      
        public Mokinys(string pav, int[] paz)
        {
            this._pavarde = pav;
            this.Pazymiai = paz.ToList();
        }

        public void SkaiciuotiVidurki()
        {
            Vidurkis = Pazymiai.Average();
        }
    }

    public class Klase
    {
        private string _pavadinimas;
        public string Pavadinimas
        {
            get { return _pavadinimas; }
            set { _pavadinimas = value; }
        }
        public double Vidurkis { get; set; }

        public Mokinys Geriausias;
        public List<Mokinys> mokiniai;

        public Klase(string pavad, params Mokinys[] m)
        {
            this._pavadinimas = pavad;
            this.mokiniai = m.ToList();
        }

        public void SkaiciuotiKlasesVid()
        {
            mokiniai.ForEach(x =>
            {
                if (x.Vidurkis == 0)
                {
                    x.SkaiciuotiVidurki();
                }
            });
            Vidurkis = mokiniai.Select(x => x.Vidurkis).Average();
        }
        public void RastiGeriausiaVidurki()
        {
            mokiniai.ForEach(x =>
            {
                if (x.Vidurkis == 0)
                {
                    x.SkaiciuotiVidurki();
                }
            });
            double max = mokiniai.Max(y => y.Vidurkis);
            Geriausias = mokiniai.First(y => y.Vidurkis == max);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Klase k1 = new Klase("10a",
                new Mokinys("Petrauskas", new int[] { 10, 2, 8, 9, 5, 6, 7 }),
                new Mokinys("Jonauskas", new int[] { 10, 10, 8, 6, 9, 10, 7 }),
                new Mokinys("Grumbliauskaitë", new int[] { 10, 3, 8, 9, 5, 8, 7 }),
                new Mokinys("Antanauskaitë", new int[] { 10, 9, 8, 4, 7, 6, 7 })
            );

            Klase k2 = new Klase("10b",
                new Mokinys("Kloðas", new int[] { 4, 2, 8, 5, 5, 7, 7 }),
                new Mokinys("Bloðas", new int[] { 10, 2, 2, 3, 4, 6, 3 }),
                new Mokinys("Matulytë", new int[] { 8, 2, 8, 4, 5, 6, 7 })
            );

            Klase k3 = new Klase("10c",
                new Mokinys("Rinkevièius", new int[] { 10, 8, 4, 5, 5, 6, 7, 4, 6 }),
                new Mokinys("Petkevièiutë", new int[] { 9, 2, 8, 4, 5, 10 }),
                new Mokinys("Jonaitis", new int[] { 7, 10, 8, 4, 3, 6, 8, 3 }),
                new Mokinys("Petraitis", new int[] { 10, 9, 8, 4 }),
                new Mokinys("Kabokas", new int[] { 6, 2, 6, 9, 8, 6, 7 }),
                new Mokinys("Martinytë", new int[] { 8, 2, 8, 4, 5, 6, 8, 9, 1, 3 })
            );

            List<Klase> klases = new List<Klase> { k1, k2, k3 };

            klases.ForEach(x =>
            {
                x.SkaiciuotiKlasesVid();
                x.RastiGeriausiaVidurki();
            }
            );

            foreach (Klase k in klases)
            {
                Console.WriteLine("Klase '{0}', vidurkis: {1}", k.Pavadinimas, k.Vidurkis);
                Console.WriteLine("Geriausias mokinys: '{0}', vidurkis {1}", k.Geriausias.Pavarde, k.Geriausias.Vidurkis);
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}