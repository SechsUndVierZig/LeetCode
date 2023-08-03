using System;
using System.Collections.Generic;

public class Assignment207
{
    public class Solution
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            List<List<int>> adjList = new List<List<int>>();
            for (int i = 0; i < numCourses; i++)
                adjList.Add(new List<int>());

            // Populate adjacency list with prerequisites
            foreach (int[] prerequisite in prerequisites)
            {
                int course = prerequisite[0];
                int prerequisiteCourse = prerequisite[1];
                adjList[course].Add(prerequisiteCourse);
            }


            bool[] visited = new bool[numCourses];
            bool[] recursionStack = new bool[numCourses];

            for (int course = 0; course < numCourses; course++)
            {
                if (HasCycle(course, adjList, visited, recursionStack))
                {
                    return false;
                }
            }

            return true;
        }

        private bool HasCycle(int course, List<List<int>> adjList, bool[] visited, bool[] recursionStack)
        {
            visited[course] = true;
            recursionStack[course] = true;

            foreach (int prerequisiteCourse in adjList[course])
            {
                if (recursionStack[prerequisiteCourse])
                    return true;
                if (!visited[prerequisiteCourse] && HasCycle(prerequisiteCourse, adjList, visited, recursionStack))
                    return true;
            }
            recursionStack[course] = false;

            return false;
        }
    }
}
