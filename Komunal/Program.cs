namespace Komunal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odenis sehifesi acilsin: (y/n)");
            char paymentPage = char.Parse(Console.ReadLine());
            if (paymentPage =='y' || paymentPage == 'Y')
            {
                Console.WriteLine("Komunal odenis siyahisini ekrana goster");
                Console.WriteLine($"1.Azeriqaz\n" +
                    $"2.Azersu\n" +
                    $"3.AzeriQaz");
                Console.WriteLine("Komunal odenislerden birini secin: ");
                int selected = int.Parse(Console.ReadLine());
                if(selected == 1)
                {
                    Console.WriteLine("Azeriqaz");
                }
                else if(selected == 2)
                {
                    Console.WriteLine("Azersu");
                }
                else if (selected == 3)
                {
                    Console.WriteLine("Azeriqaz");
                }
                else
                {
                    Console.WriteLine("Bu cur komunal xidemti yoxdur");
                }
                Console.WriteLine("Hesab nomresini daxil et (ilk 8 reqemi)");
                int countNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Mebleg daxil et: ");
                int salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Komunal nomresini ve odenis miqdari ekrana cap olunsun ? (y/n)");
                char yesOrno = char.Parse(Console.ReadLine());
                if ((yesOrno == 'y') || (yesOrno == 'Y'))
                {
                    Console.WriteLine("Print: ");
                    Console.WriteLine("Komunal tipi:"+selected);
                    Console.WriteLine($"Komunalin ilk 8 reqemi: {countNumber}");
                    Console.WriteLine($"odenis miqdari: {salary} AZN");
                }
                else
                {
                    Console.WriteLine("FINISH");
                }


            }
            else
            {
                Console.WriteLine("FINISH");
            }
        }
    }
}
