namespace CSharp2_BrekOutRoom_Lekce2_2

{ //Upravte tridu Clovek tak, aby konstruktor vyhodil vyjimku, pokud jmeno neni platne (null nebo prazdny string)
  //nebo pokud tel cislo neni validni (zkontrolujte pocet cislic). Tip: Delku cisla zjistite zavolanim telCislo.ToString().Length.
  //Do metody Main doplnte blok try-catch, ktery uzivatele upozorni, pokud udela chybu
  //Muzete pouzit obecnou tridu Exception, nebo lepe specifickou ArgumentException

    public class Clovek
    {
        public string Jmeno;
        public int TelCislo;

        public Clovek(string jmeno, int telCislo)
        {
            if (jmeno == null || jmeno == "") //
            {
                throw new Exception("Jmeno neni validni.");
            }


            Jmeno = jmeno;
            TelCislo = telCislo;
        }

        public string VypisJmenoACislo()
        {
            return $"{Jmeno}: {TelCislo}";
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Program na vytvareni telefonniho seznamu");
            Console.WriteLine("========================================");
            Console.Write("Zadejte jmeno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadejte telefonni cislo: ");
            string cislo = Console.ReadLine();

            try
            {
                if (cislo == null || cislo.Length != 9)
                {
                    Console.WriteLine("Mas spatne cislo");
                    return;
                }

                Clovek prvniClovek = new Clovek(jmeno, int.Parse(cislo));
                prvniClovek.VypisJmenoACislo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.ReadLine();

        }
    }
}
