using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class AsteroidCollision
    {
        //Time Complexity O(n)
        //Space Complexity O(n)
        /*public int[] AsteroidCollisionSol(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < asteroids.Length; i++)
            {
                if (asteroids[i] > 0)
                {
                    stack.Push(asteroids[i]);
                }
                else
                {
                    while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < Math.Abs(asteroids[i]))
                    {
                        stack.Pop();
                    }
                    if (stack.Count > 0 && stack.Peek() == Math.Abs(asteroids[i]))
                    {
                        stack.Pop();
                    }
                    else if (stack.Count == 0 || stack.Peek() < 0)
                    {
                        stack.Push(asteroids[i]);
                    }
                }
            }
            Console.WriteLine($"AsteroidCollision: {stack.ToArray().Reverse().ToArray()}");
            return stack.ToArray().Reverse().ToArray();
        }*/


        public int[] AsteroidCollisionSol(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < asteroids.Length; i++)
            {
                int asteroid = asteroids[i];
                if (asteroid > 0)
                {
                    stack.Push(asteroid);
                }
                else
                {
                    while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < -asteroid)
                    {
                        stack.Pop();
                    }
                    if (stack.Count == 0 || stack.Peek() < 0)
                    {
                        stack.Push(asteroid);
                    }
                    else if (stack.Peek() == -asteroid)
                    {
                        stack.Pop();
                    }
                }
            }
            int[] result = new int[stack.Count];
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                result[i] = stack.Pop();
            }

            return result;
        }



    }
}
