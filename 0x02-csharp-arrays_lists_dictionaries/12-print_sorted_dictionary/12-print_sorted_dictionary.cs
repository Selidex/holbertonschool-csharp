using System;
using System.Collections.Generic;

class Dictionary{
    public static void PrintSorted(Dictionary<string, string> myDict){
        List<string> newList = new List<string>();
        foreach(KeyValuePair<string, string> entry in myDict)
        {
            newList.Add(entry.Key);
        }
        newList.Sort();
        for(int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine("{0}: {1}", newList[i], myDict[newList[i]]);
            }
    }
}