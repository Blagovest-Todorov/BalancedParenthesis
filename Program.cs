using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
           
            Stack<char> openParenthesis = new Stack<char>();
            bool isBalanced = true;

            foreach (char c in expression)    // {[()]}
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    openParenthesis.Push(c);
                }
                else
                {  
                    if (!openParenthesis.Any())
                    {
                        isBalanced = false;
                        break;
                    }

                    char currOpenParenthesis = openParenthesis.Pop();

                    bool isRoundBalanced = currOpenParenthesis == '(' && c == ')';
                    bool isCurlyBalanced = currOpenParenthesis == '{' && c == '}';
                    bool isSquareBalanced = currOpenParenthesis == '[' && c == ']';

                    if (isRoundBalanced == false && 
                        isCurlyBalanced == false && isSquareBalanced == false)
                    {
                        isBalanced = false;
                        break;
                    }
                } 
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        //}
    }
}
