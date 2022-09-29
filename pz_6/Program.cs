namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v = 0;
            double g = 9.8;
            double t = 0;

            while (t <= 5)
            {
                t = t + 0.5;
                v = g * t; 
                Console.WriteLine(v);
            } 
        }
    } 
}