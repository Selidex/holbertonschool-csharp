using System;
using System.Collections.Generic;

class List{
    public static int MaxInteger(List<int> myList){
        if(myList == null || myList.Count == 0)
            return -1;
        int max = myList[0];
        for(int i = 1; i < myList.Count; i++)
        {
            if(max < myList[i])
            {
                max = myList[i];
            }
        }
        return max;
    }
}
