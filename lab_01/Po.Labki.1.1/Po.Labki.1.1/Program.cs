using System;


namespace Po.Labki._1._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ułamek[] Ułamki = new Ułamek[]
            {
                new Ułamek(4, 7),
                new Ułamek(13, 17),
                new Ułamek(25, 100)


            };
            Console.WriteLine("Nie posortowane");
            for (int i = 0; i < Ułamek.Length; ++i)
                Console.WriteLine(Ułamki[i]);

            Array.Sort(Ułamek);

            Console.WriteLine("Posortowane po wielkości mianownika");
            for (int i = 0; i < Ułamek.length ; ++i)
                Console.WriteLine(Ułamki[i]);
        }
    }
    public class Ułamek: IEquatable<Ułamek>, IComparable<Ułamek>
    {
        public int Licznik { get; }

        public int Mianownik { get; }

        Ułamek()
        {

        }

        Ułamek(int licznik, int mianownik)
        {
            this.Mianownik = mianownik;
            this.Licznik = licznik;
        }

        Ułamek(Ułamek Ułamek)
        {
            this.Licznik = Ułamek.Licznik;
            this.Mianownik = Ułamek.Mianownik;
        }
        public int CompareTo(Ułamek other)
        {
            if (other == null) return -1;
            if (other == this) return 0;
            {
                int diff = this.Mianownik - other.Mianownik;
                if (diff > 0) return +1;
                if (diff < 0) return -1;

                return 0;
            }

        }
        public bool Equals(Ułamek other)
        {
            if (other == null) return false;
            if (other == this) return true;

            return Object.Equals(this.Licznik, other.Licznik) && Object.Equals(this.Mianownik, other.Mianownik);
        }
        public override string ToString()
        {
            return Licznik.ToString() + " / " + Mianownik.ToString();
        }

    }
}
