using System;
namespace BalacedBrackets;
class Program {
    static void Main(string[] args)
    {
        string brackets = Console.ReadLine();
        Stack<char> stack = new Stack<char>();
        bool areBalanced = false;

        foreach (char brecket in brackets)
        {
            if (brecket == '{' || brecket == '[' || brecket == '(')
            {
                stack.Push(brecket);
            }
            else if (brecket == '}' || brecket == ']' || brecket == ')')
            {
                if (stack.Count == 0)
                {
                    areBalanced = false;
                    break;
                }
                
                if (brecket == ')' && stack.Pop() == '(')
                {
                    areBalanced = true;
                    
                }
                else if (brecket == ']' && stack.Pop() == '[')
                {
                    areBalanced = true;
                }
                else if (brecket == '}' && stack.Pop() == '{')
                {
                    areBalanced = true;
                }
                else
                {
                    break;
                }
            }
        }
        if (areBalanced)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

 