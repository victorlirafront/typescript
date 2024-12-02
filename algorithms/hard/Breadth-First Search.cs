using System;
using System.Collections.Generic;

class Program {
    static void BFS(Dictionary<int, List<int>> graph, int start) {
        var visited = new HashSet<int>();
        var queue = new Queue<int>();

        queue.Enqueue(start);
        visited.Add(start);

        while (queue.Count > 0) {
            int node = queue.Dequeue();
            Console.WriteLine($"Visitando: {node}");

            foreach (var neighbor in graph[node]) {
                if (!visited.Contains(neighbor)) {
                    queue.Enqueue(neighbor);
                    visited.Add(neighbor);
                }
            }
        }
    }

    static void Main() {
        var graph = new Dictionary<int, List<int>> {
            { 0, new List<int> { 1, 2 } },
            { 1, new List<int> { 0, 3, 4 } },
            { 2, new List<int> { 0, 5, 6 } },
            { 3, new List<int> { 1 } },
            { 4, new List<int> { 1 } },
            { 5, new List<int> { 2 } },
            { 6, new List<int> { 2 } }
        };

        BFS(graph, 0);
    }
}
