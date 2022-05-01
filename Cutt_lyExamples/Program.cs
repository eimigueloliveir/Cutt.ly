using System;
using Cutt_ly;

namespace Cutt_lyExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cutt cutt = new Cutt();
                cutt.key = "Your key";
                cutt.ShortLinkGenerator("https://github.com/eimigueloliveir");
                Console.WriteLine(cutt.Value.ShortLink);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
