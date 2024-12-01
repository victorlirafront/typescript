using System;
using System.Collections.Generic;

class Program {
    static int MinDistance(int[] dist, bool[] visited) {
        int min = int.MaxValue, minIndex = -1;
        for (int v = 0; v < dist.Length; v++) {
            if (!visited[v] && dist[v] <= min) {
                min = dist[v];
                minIndex = v;
            }
        }
        return minIndex;
    }

    static void Dijkstra(int[,] graph, int src) {
        int n = graph.GetLength(0);
        int[] dist = new int[n];
        bool[] visited = new bool[n];

        for (int i = 0; i < n; i++) {
            dist[i] = int.MaxValue;
            visited[i] = false;
        }
        dist[src] = 0;

        for (int count = 0; count < n - 1; count++) {
            int u = MinDistance(dist, visited);
            visited[u] = true;

            for (int v = 0; v < n; v++) {
                if (!visited[v] && graph[u, v] != 0 &&
                    dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v]) {
                    dist[v] = dist[u] + graph[u, v];
                }
            }
        }

        for (int i = 0; i < n; i++) {
            Console.WriteLine($"Distância de {src} para {i}: {dist[i]}");
        }
    }

    static void Main() {
        int[,] graph = {
            { 0, 4, 0, 0, 0, 0 },
            { 4, 0, 8, 0, 0, 0 },
            { 0, 8, 0, 7, 0, 4 },
            { 0, 0, 7, 0, 9, 14 },
            { 0, 0, 0, 9, 0, 10 },
            { 0, 0, 4, 14, 10, 0 }
        };
        Dijkstra(graph, 0);
    }
}
