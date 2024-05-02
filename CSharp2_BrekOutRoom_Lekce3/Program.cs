namespace CSharp2_BrekOutRoom_Lekce3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            /*string oddelovac = new string('-', 20);
            Console.WriteLine($"{oddelovac}");

            char acko = 'a';
            char velkeAcko = 'A';
            Console.WriteLine(acko);
            Console.WriteLine(velkeAcko);
            int ciselnaHodnotaAcka = (int)acko;
            int ciselnaHodnotaVelkehoAcka = (int)velkeAcko;
            Console.WriteLine(ciselnaHodnotaAcka);
            Console.WriteLine(ciselnaHodnotaVelkehoAcka);
            Console.WriteLine(acko + velkeAcko);

            string prazdny = "";
            string takePrazdny = string.Empty;
            Console.WriteLine(prazdny.Length + "a" + takePrazdny.Length);

            string nulovy = null;
            Console.WriteLine(nulovy.Length);

            Console.WriteLine("Zadej vstup");
            string vstup = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(vstup))
            {
                Console.WriteLine("Spatny vstup.");
                Console.WriteLine("Zadej vstup znovu");
                vstup = Console.ReadLine();*/

            //string a = "ahoj";
            //string b = "ty";
            //Console.WriteLine(string.Concat(a, b));

            //string uzivatelskeJmeno = "Anna";
            //string heslo = "Czechitas";
            //Console.WriteLine("Zadej jmeno");
            //string vstupJmeno = Console.ReadLine();

            //if (string.Equals(vstupJmeno, uzivatelskeJmeno, StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("Zadej heslo");
            //    string vstupHeslo = Console.ReadLine();

            //    if (string.Equals(vstupHeslo, heslo, StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine("Vitej");

            //    }
            //}

            string dlouhyText = "Ahoj Pepo, jak se mas? Ahoj.";
            bool obsahujePepu = dlouhyText.Contains("pepo", StringComparison.OrdinalIgnoreCase);
            int indexPepa = dlouhyText.IndexOf("Pepo");
            Console.WriteLine($"Obsajhuje Pepu: {obsahujePepu}");
            Console.WriteLine($"Obsajhuje Pepu na pozici: {indexPepa}");

            Console.WriteLine(dlouhyText.StartsWith("oh", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(dlouhyText.EndsWith("j.", StringComparison.OrdinalIgnoreCase));

            string prvnich10 = dlouhyText.Substring(startIndex: 0, length: 2);
            Console.WriteLine($"Prvnich 10 znaku je: {prvnich10}");

            string pozdravHonzy = dlouhyText.Replace("Pepo", "Honzo");
            Console.WriteLine(pozdravHonzy);

            string pozdravPepySCau = dlouhyText.Replace("Ahoj", "Cau");
            Console.WriteLine(pozdravPepySCau);
        }







    }
}

