using System;

    class Number{
        public static int PrintLastDigit(int number)
        {
            int last = number % 10;
            if(last < 0)
            {
                Console.Write("{0}", last * -1);
                return last * -1;
            }
            else
            {
                Console.Write("{0}", last);
                return last;
            }
        }
    }
