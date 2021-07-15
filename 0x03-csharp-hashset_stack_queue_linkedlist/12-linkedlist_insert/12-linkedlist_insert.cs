using System;
using System.Collections.Generic;

class LList{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n){
        LinkedListNode<int> insert = myLList.First;
        if(myLList.First == null || n < myLList.First.Value)
        {
            myLList.AddFirst(n);
            return myLList.First;
        }
        while(insert != null){
            if(insert.Next != null && n < insert.Next.Value)
            {
                myLList.AddAfter(insert, n);
                return insert.Next;
            }
            insert = insert.Next;
        }
        myLList.AddLast(n);
        return myLList.Last;
    }
}