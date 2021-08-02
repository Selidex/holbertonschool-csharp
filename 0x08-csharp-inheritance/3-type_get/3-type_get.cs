using System;
using System.Collections.Generic;
using System.Reflection;

class Obj{
    public static void Print(object myObj){
        PropertyInfo[] myPropertyInfo;
        MethodInfo[] myMethods;

        myPropertyInfo = myObj.GetType().GetProperties();
        myMethods = myObj.GetType().GetMethods();
        System.Console.WriteLine("{0} Properties:", myObj.GetType().Name);
        for (int i = 0; i < myPropertyInfo.Length; i++)
        {
            System.Console.WriteLine(myPropertyInfo[i].Name);
        }
        System.Console.WriteLine("{0} Methods:", myObj.GetType().Name);
        for(int i = 0; i < myMethods.Length; i++)
        {
            System.Console.WriteLine(myMethods[i].Name);
        }
        
    }
}