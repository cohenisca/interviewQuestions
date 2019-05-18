using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewQuestions.Intel
{
    public class Q2
    {
        public  Node Head;
        public Node Tail;
        

        public Q2()
        {
            Head = new Node();
            Node a = Head;
            for (int i = 0; i < 10; i++)
            {
                a.value = i;
                a.Next = new Node();
                a = a.Next;
            }

            Tail = a;
            Tail.Next = null;


            Print( Head);
            Reverse(ref Head);
            Console.WriteLine();
            Print(Head);

        }

        private void Print(Node node)
        {
            while (node.Next != null)
            {
                Console.Write(node.value + "-> " );
                node = node.Next;
            }
        }

        public void Reverse(ref Node Head)
        {
            Swap(ref Head);
            Node temp = Head;
            Tail = Head;
            Head = temp;
            Tail.Next = null;
        }

        public void Swap(ref Node node)
        {
            if (node.Next.Next != null)
            {
                Swap(ref node.Next);
            }
            node.Next = node;
        }



        public class Node
        {
            public Node Next;
            public int value { get; set; }
            public override string ToString()
            {
                return value.ToString();
            }
        }
    }


}
