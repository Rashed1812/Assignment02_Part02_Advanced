namespace Assignment02_Part02_Advanced
{
    internal class Program
    {

        #region 2.Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

        static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.Count == 0) 
                        return false;

                    char top = stack.Pop();


                    if ((ch == ')' && top != '(') ||  (ch == '}' && top != '{') || (ch == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        } 

        #endregion

        static void Main(string[] args)
        {
            #region 1.Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //Console.WriteLine($"Queue Capacity:{queue.Capacity} Queue Count:{queue.Count}");
            //foreach (var item in queue)
            //{
            //    Console.Write($"{item} ");
            //}

            //Stack<int> stack = new Stack<int>();

            //while (queue.Count > 0)
            //{
            //    stack.Push(queue.Dequeue());
            //}

            //Console.WriteLine($"\n\nStack Capacity:{stack.Capacity} Stack Count:{stack.Count}");
            //Console.WriteLine("After Reverse Using Stack");

            //foreach (var item in stack)
            //{
            //    Console.Write($"{item} ");
            //} 

            #endregion

            #region 2.Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
           
            //string Input = "[()]{}";
            //Console.WriteLine($"Input: {Input}  \nOutput: {(IsBalanced(Input) ? "Balanced" : "Not Balanced")}"); 

            #endregion

        }
    }
}
