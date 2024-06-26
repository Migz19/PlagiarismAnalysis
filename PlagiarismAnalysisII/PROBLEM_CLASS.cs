﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem
{
    public static class PROBLEM_CLASS
    {

        private static Dictionary<string, List<(string, float)>> adjacencyList = new Dictionary<string, List<(string, float)>>();

        public static void RequiredFunction(Tuple<string, string, float>[] edges, ref float maxAvgScore, ref List<string> IDs)
        {
            
            adjacencyList = new Dictionary<string, List<(string, float)>>();
          
            foreach (var edge in edges)
{
AddEdge(edge.Item1, edge.Item2, edge.Item3);
}


List<List<string>> connectedComponents = FindConnectedComponents();

float maxAverageScore = float.MinValue;
List<string> maxAvgScoreIDs = new List<string>();

foreach (var connectedComponent in connectedComponents)
{
float componentSum = 0f;
int componentCount = 0;


foreach (var vertex in connectedComponent)
{
    if (adjacencyList.ContainsKey(vertex))
    {
        foreach ((string neighbor, float weight) in adjacencyList[vertex])
        {
            componentSum += weight;
            componentCount++;
        }
    }
}

float componentAvgScore = componentCount > 0 ? componentSum / componentCount : 0f;


if (componentAvgScore > maxAverageScore)
{
    maxAverageScore = componentAvgScore;
    maxAvgScoreIDs = connectedComponent.ToList();
}
}


maxAvgScore = maxAverageScore;
IDs = maxAvgScoreIDs;
}

public static void AddEdge(string u, string v, float weight)
{
if (!adjacencyList.ContainsKey(u))
adjacencyList[u] = new List<(string, float)>();

if (!adjacencyList.ContainsKey(v))
adjacencyList[v] = new List<(string, float)>();

adjacencyList[u].Add((v, weight));
adjacencyList[v].Add((u, weight)); // Assuming undirected graph
}

private static void DFS(string vertex, Dictionary<string, bool> visited, List<string> component)
{
visited[vertex] = true;
component.Add(vertex);

if (adjacencyList.ContainsKey(vertex))
{
foreach ((string neighbor, float weight) in adjacencyList[vertex])
{
    if (!visited.ContainsKey(neighbor) || !visited[neighbor])
    {
        DFS(neighbor, visited, component);
    }
}
}
}

        public static List<List<string>> FindConnectedComponents()
        {
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            List<List<string>> connectedComponents = new List<List<string>>();

            foreach (var vertex in adjacencyList.Keys)
            {
                if (!visited.ContainsKey(vertex) || !visited[vertex])
                {
                    List<string> component = new List<string>();
                    DFS(vertex, visited, component);
                    connectedComponents.Add(component);
                }
            }

            return connectedComponents;
        }
    }}
