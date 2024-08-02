using System.Collections.Generic;
using System.Xml.Linq;

namespace gh_Day10_2
{
    /* 과제2. 요세푸스 순열
       아래의 요세푸스 순열에 대한 설명을 보고, N와 K 가 주어지면 결과를 출력하는 프로그램으로 구현하시오.
       
       1. 1번부터 N번까지, N명의 사람이 원을 이루면서 앉아 있고, 양의 정수 K( ≤ N)가 주어진다.
       2. 이제 순서대로 K번째 사람을 제거한다.
       3. 한 사람이 제거되면, 남은 사람들로 이루어진 원을 따라 해당 과정을 계속한다.
       4. 해당 과정은 N명의 사람이 모두 제거될 때 까지 계속된다.
       5. 원에서 사람들이 제거되는 순서를 ' (K,K)-요세푸스 순열 ' 이라고 한다. (ex, (7, 3)요세푸스 순열 = <3, 6, 2, 7, 5, 1, 4>)

    */

    public class gh02
    {
        //public class k
        //{
        //    public int K;

        //    public k()
        //    {
        //        // K는 N의 수 보다 크거나 같을 수 없다.
        //        if (K == 9)
        //        {
        //            bool answer = false;
        //            break;
        //        }
        //    }     
        //}


        static void Main()
        {
            LinkedList<int> human = new LinkedList<int>();

            // 1번부터 N번까지, N명의 사람이 원을 이루면서 앉아 있고, 양의 정수 K( ≤ N)가 주어진다.
            // N을 임시로 9로 정의한다.
            LinkedListNode<int> One = human.AddFirst(1);
            LinkedListNode<int> Two = human.AddFirst(2);
            LinkedListNode<int> Three = human.AddFirst(3);
            LinkedListNode<int> Four = human.AddFirst(4);
            LinkedListNode<int> Five = human.AddFirst(5);
            LinkedListNode<int> Six = human.AddFirst(6);
            LinkedListNode<int> Seven = human.AddFirst(7);
            LinkedListNode<int> Eight = human.AddFirst(8);
            LinkedListNode<int> Nine = human.AddFirst(9); // = N

            int K = 3; // 양의 정수 'K'. 임시로 3으로 정의한다.
            LinkedListNode<int> All = Nine.Previous;


            // 한 사람이 제거되면, 남은 사람들로 이루어진 원을 따라 해당 과정을 계속한다.
            // 해당 과정은 N명의 사람이 모두 제거될 때 까지 계속된다.
            for (LinkedListNode<int> H = human.First; H != null; H = H.Next)
            {
                // 순서대로 K번째 사람을 제거한다.
                human.Remove(K);

                if (K = human.First)  // K가 남은 human값과 같을 때 멈춤.
                    // 출력 실패...!!
                {
                    Console.WriteLine($"{All}");
                }
            }
        }
    }
}
