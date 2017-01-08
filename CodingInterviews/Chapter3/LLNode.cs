using System.Collections.Generic;

namespace CodingInterviews.Chapter3
{
    public class LLNode
    {
        public LLNode Next { get; set; }

        public int Data { get; set; }

        public LLNode(int data, LLNode next)
        {
            this.Data = data;
            this.Next = next;
        }

        public override string ToString()
        {
            return string.Format("{0}->{1}", this.Data, this.Next);
        }

        public static LLNode MakeList(params int[] list)
        {
            LLNode node = null;
            for (int i = list.Length - 1; i >= 0; i--)
            {
                node = new LLNode(list[i], node);
            }
            return node;
        }

        public int[] ToArray()
        {
            List<int> list = new List<int>();
            LLNode head = this;
            while (head != null)
            {
                list.Add(head.Data);
                head = head.Next;
            }
            return list.ToArray();
        }
    }
}