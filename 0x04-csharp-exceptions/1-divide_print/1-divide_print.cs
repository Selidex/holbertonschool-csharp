using System;

class Int{
    public static void divide(int a, int b){
        int x = 0;
        try{
            x = a / b;
        }
        catch(DivideByZeroException){
            System.Console.WriteLine("Cannot divide by zero");
            x = 0;
        }
        finally{
            System.Console.WriteLine("{0} / {1} = {2}", a, b, x);
        }
        }
    }