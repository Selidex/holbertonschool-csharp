using System;
using System.Collections.Generic;

class List{
    public static List<int> DeleteAt(List<int> myList, int index){
        if (index < 0 || myList == null || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }
        for(int i = myList.Count - 1; i >= 0; i--){
            if(i == index)
                myList.Remove(i + 1);
        }
        return myList;
    }
}