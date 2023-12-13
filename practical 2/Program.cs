
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] heights = { 2, 1, 5, 6, 2, 3 };
//        int maxArea = LargestArea(heights);
//        Console.WriteLine(maxArea); 
//    }
//    static int LargestArea(int[] heights)
//    {
//        int maxArea = 0;
//        Stack<int> stack = new Stack<int>();

//        for (int i = 0; i <= heights.Length; i++)
//        {
//            int currentHeight = (i == heights.Length) ? 0 : heights[i];

//            while (stack.Count > 0 && currentHeight <= heights[stack.Peek()])
//            {
//                int top = stack.Pop();
//                int width = (stack.Count == 0) ? i : i - stack.Peek() - 1;
//                int area = heights[top] * width;
//                maxArea = Math.Max(maxArea, area);
//            }

//            stack.Push(i);
//        }

//        return maxArea;
//    }
//}


//using System;
//using System.Collections.Generic;

//class program
//{
//    static void Main(string[] args)
//    {
//        program validator = new program();
//        Console.WriteLine(validator.bracket("()(())((()()))")); 
//        Console.WriteLine(validator.bracket("()(()))"));
//    }
//    public bool bracket(string input)
//    {
//        Stack<char> stack = new Stack<char>();

//        foreach (char c in input)
//        {
//            if (c == '(')
//            {
//                stack.Push(c);
//            }
//            else if (c == ')')
//            {
//                if (stack.Count == 0 || stack.Peek() != '(')
//                {
//                    return false;
//                }
//                stack.Pop();
//            }
//        }

//        return stack.Count == 0;
//    }

//}





