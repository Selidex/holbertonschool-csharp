using System;


    class Queue<T>
    {
        public object CheckType(){
            return typeof(T);
        }
        class Node{
            public dynamic value = null;
            public Node next = null;
            public Node(dynamic val){
                value = val;
            }
        }
        Node head;
        Node tail;
        int count;
        public void Enqueue(dynamic value){
            Node king = new Node(value);
            if(count == 0){
                head = king;
                tail = king;
            }
            else{
                tail.next = king;
                tail = king;}
            count++;
            }
        public int Count(){
            return count;
        }
    }
