using System;
using System.Collections.Generic;

class LList{
    public static int FindNode(LinkedList<int> myLList, int value){
        if(!myLList.Contains(value))
            return -1;
        LinkedListNode<int> check = myLList.First;
        int i;
        for(i = 0; check.Value != value; i++)
            check = check.Next;
        return i;
    }
}