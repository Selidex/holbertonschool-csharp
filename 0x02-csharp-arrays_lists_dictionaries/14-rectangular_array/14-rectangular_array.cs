using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            var newArray = new int [5,5];
            newArray[2,2] = 1;
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    System.Console.Write("{0}", newArray[i,j]);
                    if(j == 4)
                        Console.Write("\n");
                    else
                        Console.Write(" ");
                }
            }
        }
    }
}
