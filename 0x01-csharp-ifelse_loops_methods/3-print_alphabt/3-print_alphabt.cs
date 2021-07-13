using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char a = 'a'; a <= 'z'; a++)
            {
                if (a != 'e' && a != 'q')
                    Console.Write("{0}", a);
            }
        }
    }
}