using System;
using System.Collections.Generic;

class LList{
    public static int GetNode(LinkedList<int> myLList, int n){
        if(n < 0 || n >= myLList.Count)
            return 0;
        LinkedListNode<int> check = myLList.First;
        for(int i = 0; i < n; i++)
            check = check.Next;
        return check.Value;
    }
}