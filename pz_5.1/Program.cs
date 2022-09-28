namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
          { 
            Console.WriteLine("работа с git");
          }
            int i;
            for (i = -50; i < 0; i += 5)
                Console.WriteLine(i);

            Console.WriteLine("номер 2");
            char a;
            for (a = 'л'; a != 'т'; a++)
                Console.Write("{0}", a);

            Console.WriteLine("номер 3");
            int n;
            int m;
            for (n = 0; n < 4; n++)
            {
                for (m = 0; m < 10; m++)
                    Console.Write("{#}");
                Console.WriteLine("\n");
            }

            Console.WriteLine("номер 4");
            int kratnoe = 14;
            int c;
            for (c = 0; c != 100; c++)
                if (c % kratnoe == 0)
                    Console.WriteLine(c);

            Console.WriteLine("номер 5");
            int z;
            int v = 45;
            for (z = 0; v - z != 17; z++)
                Console.WriteLine(z);

        }
    }
}