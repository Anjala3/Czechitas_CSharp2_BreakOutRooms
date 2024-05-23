namespace CSharp2_BrekOutRoom_Lekce6
{
    public class Obdelnik
    {
        public int Sirka { get; private set; }
        public int Vyska { get; private set; }
        public string Jmeno { get; private set; }

        private int pomocnaObsah;
        private bool obsahUpraveny = false;

        public int Obsah
        {
            get { return pomocnaObsah; }
            private set
            {
                if (value == 0)
                {
                    pomocnaObsah = 1;
                    obsahUpraveny = true;
                }
                else
                {
                    pomocnaObsah = value;
                }
            }
        }

        public int Obvod
        {
            get { return 2 * (Sirka + Vyska); }
        }

        public Obdelnik(int sirka, int vyska, string jmeno)
        {
            Sirka = sirka;
            Vyska = vyska;
            Jmeno = jmeno;
            Obsah = Sirka * Vyska;
        }

        public Obdelnik(int sirka) : this(sirka, sirka, "Ctverec") { }

        public void VypisInformace()
        {
            Console.WriteLine($"Sirka obdelniku {Jmeno} je: {Sirka}, jeho vyska je {Vyska}");
        }

        public void ZvetsiObdelnik()
        {
            Sirka *= 2;
            Vyska *= 2;
            Obsah = Sirka * Vyska;
            Console.WriteLine($"Nove rozmery obdelniku {Jmeno} - Sirka: {Sirka}, Vyska: {Vyska}");
        }

        public void VypisObvod()
        {
            Console.WriteLine($"Obvod obdelniku {Jmeno} je: {Obvod}");
        }

        public void VypisObsah()
        {
            if (obsahUpraveny)
            {
                Console.WriteLine($"Obsah nemuze byt nula! Obsah obdelniku {Jmeno} byl nastaven na 1.");
            }
            else
            {
                Console.WriteLine($"Obsah obdelniku {Jmeno} je: {Obsah}");
            }
        }
    }
}
