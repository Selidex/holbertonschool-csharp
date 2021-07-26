using System;

class Int{
    public static void divide(int a, int b){
        try{
            int x = a / b;
            System.Console.WriteLine("{0} / {1} = {2}", a, b, a/b);
        }
        catch(DivideByZeroException){
            System.Console.WriteLine("Cannot divide by zero");
            System.Console.WriteLine("{0} / 0 = 0", a);
        }
    }
}