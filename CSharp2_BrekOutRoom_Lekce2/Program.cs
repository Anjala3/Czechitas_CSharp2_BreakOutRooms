namespace CSharp2_BrekOutRoom_Lekce2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napis den odjezdu");
            int denOdjezdu = int.Parse(Console.ReadLine());

            Console.WriteLine("Napis mesic odjezdu");
            int mesicOdjezdu = int.Parse(Console.ReadLine());

            Console.WriteLine("Napis rok odjezdu");
            int rokOdjezdu = int.Parse(Console.ReadLine());

            DateTime datumOdjezdu = new DateTime(rokOdjezdu, mesicOdjezdu, denOdjezdu);
            TimeSpan zbyvajiciPocetDni = datumOdjezdu - DateTime.Today;

            if (zbyvajiciPocetDni.Days < 0)
            {
                Console.WriteLine("Dovolena uz byla.");
            }
            else
            {
                Console.WriteLine($"Do odjezdu zbyva {zbyvajiciPocetDni.Days}");
            }

        }
    }
}
