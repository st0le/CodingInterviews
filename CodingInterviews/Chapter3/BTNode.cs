using System;

namespace CodingInterviews.Chapter3
{
    public class BTNode
    {
        public BTNode Parent { get; set; }
        public BTNode Left { get; set; }
        public BTNode Right { get; set; }
        public int Data { get; set; }

        public BTNode(int data, BTNode left, BTNode right)
        {
            this.Data = data;
            this.Left = left;
            this.Right = right;

            if (this.Left != null)
            {
                this.Left.Parent = this;
            }

            if (this.Right != null)
            {
                this.Right.Parent = this;
            }
        }

        public static BTNode MakeBinaryTree(params int[] arr)
        {
            return MakeBinaryTree(arr, 0);
        }

        private static BTNode MakeBinaryTree(int[] arr, int i)
        {
            return (i < arr.Length) ? new BTNode(arr[i], MakeBinaryTree(arr, 2 * i + 1), MakeBinaryTree(arr, 2 * i + 2)) : null;
        }

        public override string ToString()
        {
            return string.Format("({1} {0} {2})", this.Data, this.Left != null ? this.Left.ToString() : "NULL", this.Right != null ? this.Right.ToString() : "NULL");
        }
    }
}