using System;

class Array{
    public static int[] CreatePrint(int size){
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] newarray = new int[size];
        for(int i = 0; i < size; i++)
        {
            newarray[i] = i;
            Console.Write("{0}", i);
            if(i != size - 1)
                Console.Write(" ");
        }
        Console.Write("\n");
        return newarray;
    }
}
