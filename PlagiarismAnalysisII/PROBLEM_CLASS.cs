using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem
{
    public static class PROBLEM_CLASS
    {
        public static void RequiredFunction(Tuple<string, string, float>[] edges, ref float maxAvgScore, ref List<string> IDs)
        {
            /* 
             Dictionary<string, List<Tuple<string, float>>> neighbors = new Dictionary<string, List<Tuple<string, float>>>();
             HashSet<string> allNodes = new HashSet<string>();

             // Populate neighbors dictionary and collect all unique nodes
             foreach (var edge in edges)
             {
                 string ID1 = edge.Item1;
                 string ID2 = edge.Item2;
                 float score = edge.Item3;

                 allNodes.Add(ID1);
                 allNodes.Add(ID2);

                 if (!neighbors.ContainsKey(ID1))
                 {
                     neighbors[ID1] = new List<Tuple<string, float>>();
                 }
                 neighbors[ID1].Add(new Tuple<string, float>(ID2, score));

                 if (!neighbors.ContainsKey(ID2))
                 {
                     neighbors[ID2] = new List<Tuple<string, float>>();
                 }
                 neighbors[ID2].Add(new Tuple<string, float>(ID1, score));
             }

             maxAvgScore = float.MinValue;
             List<string> maxScoreCommunity = new List<string>();

             foreach (var startID in allNodes)
             {
                 if (neighbors.ContainsKey(startID))
                 {
                     HashSet<string> visited = new HashSet<string>();
                     Queue<string> queue = new Queue<string>();
                     queue.Enqueue(startID);
                     visited.Add(startID);

                     float communitySum = 0;
                     int communityCount = 0;

                     while (queue.Count > 0)
                     {
                         string currentID = queue.Dequeue();
                         communitySum += neighbors[currentID].Sum(n => n.Item2);
                         communityCount += neighbors[currentID].Count;

                         foreach (var neighbor in neighbors[currentID])
                         {
                             if (!visited.Contains(neighbor.Item1))
                             {
                                 visited.Add(neighbor.Item1);
                                 queue.Enqueue(neighbor.Item1);
                             }
                         }
                     }

                     // Calculate average score for the community
                     float avgScore = communityCount > 0 ? communitySum / communityCount : 0;

                     if (avgScore > maxAvgScore)
                     {
                         maxAvgScore = avgScore;
                         maxScoreCommunity.Clear();
                         maxScoreCommunity.Add(startID);
                     }
                     else if (avgScore == maxAvgScore)
                     {
                         maxScoreCommunity.Add(startID);
                     }
                 }
             }

             IDs = maxScoreCommunity.OrderBy(id => id).ToList();



             */
            
        }

    }
}
