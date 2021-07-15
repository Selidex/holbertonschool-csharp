using System;
using System.Collections.Generic;

class LList{
    public static LinkedList<int> CreatePrint(int size){
        if(size <= 0){
            return new LinkedList<int>();
        }
        LinkedList<int> lList = new LinkedList<int>();
        for(int i = 0; i < size; i++)
        {
            lList.AddLast(i);
            System.Console.WriteLine(i);
        }
        return lList;
    }
}