namespace StringFormatMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TCno1 = "11111111111";
            string adiSoyad1 = "Ali Veli";
            int maas1 = 2500;
            double telefon1 = 5554443322;

            string TCno2 = "22222222222";
            string adiSoyadi2 = "Ayşe Fatma";
            int maas2 = 2000;
            double telefon2 = 4443332233;

            string TCno3 = "33333333333";
            string adiSoyadi3 = "Fatma Veli";
            int maas3 = 3000;
            double telefon3 = 3334445511;

            Console.WriteLine("TC Kimlik No | Adı - Soyadı         | Maaş    | Telefon No      |");
            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine(string.Format("{0,-12} | {1,-20} | {2:0000000} | {3:(###) ### ## ##} |",TCno1,adiSoyad1,maas1,telefon1));
            Console.WriteLine(string.Format("{0,-12} | {1,-20} | {2:0000000} | {3:(###) ### ## ##} |", TCno2, adiSoyadi2, maas2, telefon2));
            Console.WriteLine(string.Format("{0,-12} | {1,-20} | {2:0000000} | {3:(###) ### ## ##} |", TCno3, adiSoyadi3, maas3, telefon3));

            Console.ReadKey();
        }
    }
}
