using System;
using System.Collections.Generic;

class Dictionary{
    public static string BestScore(Dictionary<string, int> myList){
        if(myList.Count == 0 || myList == null)
            return "None";
        int maxv = -1;
        string maxk = "";
        foreach(KeyValuePair<string, int> entry in myList)
        {
            if(maxv < entry.Value)
            {
                maxv = entry.Value;
                maxk = entry.Key;
            }
        }
        return maxk;
    }
}