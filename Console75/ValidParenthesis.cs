using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class ValidParenthesis
    {
        /*
         * Time Complexity O(n) where n is the length of the string. We process each bracket in the string once.
         * 
         * Space Complexity O(n) in the worst case, if we have all open brackets, we will push all of them onto the stack.
         * 
         * The problem is to determine if a string of parentheses is valid. A string is valid if:
           Open brackets must be closed by the same type of brackets.
           Open brackets must be closed in the correct order.
           For example, “()” and “()[]{}” are all valid but “(]” and “([)]” are not.
         * 
         * We can use a stack to solve this problem. We iterate through the string, when we encounter an open bracket, 
         * we push it onto the stack. When we encounter a close bracket, we check the top of the stack. If the top of the stack is 
         * the corresponding open bracket, we pop it off the stack. If not, the string is not valid. If the stack is empty at the end, 
         * the string is valid.
         * 
         */

        public bool ValidParenthesisSol(string s) 
        {
            //Initialize a stack to hold the brackets
            Stack<char> stack = new Stack<char>();

            //Iterate over the string 
            foreach (char c in s)
            {
                //If the character is an open bracket, push it into the stack
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else 
                {
                    //If the stack is empty, the string is not valid
                    if (stack.Count == 0) 
                    {
                        return false;   
                    }

                    //Check the top of the stack
                    char top = stack.Pop();

                    //If the top of the stack is not the corresponding open bracket, the string is not valid
                    if (c == ')' && top != '(') { return false; }
                    if (c == '}' && top != '{') { return false; }
                    if (c == ']' && top != '[') { return false; }
                }
                
            }

            //If the stack is not empty at the end, the string is not valid
            return stack.Count == 0;
        }
    }
}
