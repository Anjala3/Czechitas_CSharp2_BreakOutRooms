namespace CSharp2_BrekOutRoom_Lekce6
{
    public class Obdelnik
    {
        public int Sirka;
        public int Vyska;

        public Obdelnik(int sirka, int vyska)
        {
            Sirka = sirka;
            Vyska = vyska;
        }

        public Obdelnik(int sirka) : this(sirka, sirka)
        {

        }

        public void VypisInformace()
        {
            Console.WriteLine($"Sirka obedlniku je: {Sirka}, vyska obedlniku je {Vyska}");
        }
    }
}
