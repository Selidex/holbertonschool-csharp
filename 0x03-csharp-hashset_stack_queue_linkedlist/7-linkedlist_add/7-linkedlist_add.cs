using System;
using System.Collections.Generic;
using System.Diagnostics;

class LList{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n){
        myLList.AddFirst(n);
        return myLList.First;
    }
}