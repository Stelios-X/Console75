using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class CourseSchedule
    {
        //Time Complexity  O(V + E), where V is the number of courses (vertices) and E is the number of prerequisites (edges).
        //This is because we iterate through all courses and prerequisites.
        //Space Complexity  O(V + E)
        public bool CourseScheduleSol(int numCourses, int[][] prerequisites)
        {
            // Create an adjacency list to represent the graph
            List<int>[] graph = new List<int>[numCourses];
            for (int i = 0; i < numCourses; i++)
            {
                graph[i] = new List<int>();
            }

            // Create an array to store the in-degrees of each course
            int[] inDegrees = new int[numCourses];

            // Build the graph and calculate in-degrees
            foreach (var prerequisite in prerequisites)
            {
                int course = prerequisite[0];
                int prerequisiteCourse = prerequisite[1];
                graph[prerequisiteCourse].Add(course);
                inDegrees[course]++;
            }

            // Use a queue to perform topological sorting
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < numCourses; i++)
            {
                if (inDegrees[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            // Perform topological sorting
            while (queue.Count > 0)
            {
                int course = queue.Dequeue();
                foreach (var nextCourse in graph[course])
                {
                    inDegrees[nextCourse]--;
                    if (inDegrees[nextCourse] == 0)
                    {
                        queue.Enqueue(nextCourse);
                    }
                }
            }

            // Check if all courses have been taken
            for (int i = 0; i < numCourses; i++)
            {
                if (inDegrees[i] > 0)
                {
                    return false;
                }
            }

            return true;
        }
    }






}
