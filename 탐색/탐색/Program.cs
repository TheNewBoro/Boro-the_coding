using System.ComponentModel.Design;

namespace 탐색
{
    internal class Program
    {
        public static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i <array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }

        // <이진 탐색>
        // 정렬이 되어있는 자료구조에서 2분할을 통해 데이터를 탐색
        // 단, 이진 탐색은 정렬이 되어 있는 자료에만 적용 가능
        // 시간복잡도 - 0(logn)

        public static int BinarySearch(int[] array, int target)
        {
            int low = 0;
            int high = array.Length - 1;
            while (low <= high)
                {
                    int mid = (low + high) / 2;

                    if (array[mid] > target)
                            {
                                high = mid - 1;
                            }
                    else if (array[mid] < target)
                            {
                                low = mid + 1;
                            }
                    else
                            {
                                return mid;
                            }
                }
            return -1;
        }

        //<너비 우선 탐색 (Breadth-First Search)
        // 그래프의 분기를 만났을 때 모든 분기들을 탐색한 뒤,
        // 다음 깊이의 분기들을 탐색
        // 큐를 통해 탐색
        // 장점 : 최단 경로를 보장한다.
        // 단점 : 지금 탐색상황에서 필요하지 않은 정점데이터도 큐에 보관할 필요가 있다.

        // 일반적으로 그래프에 사용을 선호함
        public static void BFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
        {
            //BFS 사전 설정 시작
            int size = graph.GetLength(0);
            visited = new bool[size];
            parents = new int[size];

            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            visited[start] = true;
            //BFS 사전 설정 끝

            while (queue.Count > 0)
            {
                // 큐에서 다음으로 탐색할 정점을 확인한다;
                int next = queue.Dequeue();

                // 다음으로 탐색할 정점을 기준으로 탐색할 수 있는 정점들을 큐에 담는다;
                for (int vertex = 0; vertex < size; vertex++) //정점들을 반복하며
                {
                    if (graph[next, vertex] == true && //연결되어 있는 정점
                        visited[vertex == false])      // 방문한 적 없는 정점
                    {
                            queue.Enqueue(vertex)//큐에 탐색할 수 있는 정점을 추가한다;
                            visited[vertex] = true;//탐색할 수 있는 정점을 반분 표시;
                            parents[vertex] = next;//탐색할 수 있는 정점을 탐색한 이전 정점을 표시한다; 
                    }
                }

            }
        }


        // <깊이 우선 탐색 (Depth-First Search)>
        // 그래프의 분기를 만났을 때 최대한 깊이 내려간 뒤,
        // 분기의 탐색을 마쳤을 때 다음 분기를 탐색
        // 스택을 통해 구현
        // 장점 : 지금 탐색상황에서 필요한 정점데이터만 보관가능하고 탐색이 끝나면 버려도 무관하다.
        // 단점 : 최단 경로를 보장하지 않는다.

        //일반적으로 트리에 사용을 선호함
        public static void DFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
        {
            int size = graph.GetLength(0);   //정점의 갯수
            visited = new bool[size];
            parents = new int[size];

            for(int i=0; i<size; i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }
        }

        // <다이스트라 알고리즘>>
        // 특정한 노드에서 출발하여 다른 노드까지 가는 각각의 최단 경로를 구하는 알고리즘
        // 1. 방문하지 않은 노드 중에서 가장 가까운 노드를 선택한 한 후,
        // 2. 선택한 노드를 거쳐서 더 짧아지는 경로가 있는 경우 대체
        const int INF = 99999;
        public static void Dijkstra(int[,] graph, int start, out bool[] visited, out int[] parents, out int[] cost)
        {
            int size = graph.GetLength(0);

            for(int i = 0; i<size; i++)
            {
                visited[i] = false;
                parents[i] = -1;
                cost[i] = INF;
            }
            cost[start] = 0;

            for(int i = 0; i<size; i++)
            {
                // 1. 방문하지 않은 정점 중 가장 가까운 정점 선택
                int minIndex = -1;
                int minCost = INF;
                for (int j=0; j<size; j++)
                {
                    if (visited[j] == false && //방문한 적 없으며
                        cost[j]<minCost)
                    {
                        minIndex = j;
                        minCost = cost[j];
                    }
                }
                // 2. 직접 연결된 거리보다 거쳐서 더 짧아지면 대체

                for(int j=0; j < size; j++)
                {
                    // cost[j] : 목적지까지 직접 연결된 거리
                    // cost[minIndex] : 중간점까지의 거리
                    // graph[minIndex,j] : 중간점부터 목적지까지 거리
                    if (cost[j] > cost[minIndex] + graph[minIndex,j])
                    {
                        cost[j] = cost[minIndex] + graph[minIndex, j];
                        parents[j] = minIndex;
                    }
                }
            }
        }

        public static void SearchNode(bool[,] graph, int vertex, bool[] visited, int[] parents)
        {
            int size = graph.GetLength(0);
            visited[vertex] = true;

            for(int i = 0; i<size; i++)
            {
                if (graph[vertex,i] == true && //연결되어 있는 정점
                    visited[i] == false)       //방문한 적 없는 정점
                {
                    parents[i] = vertex;
                    SearchNode(graph, i, visited, parents);
                }
            }

        }
        static void Main(string[] args)
        {
            //int[] array = { 0, 2, 4, 6, 8, 9, 7, 5, 3, 1 };
            //int findIndex = LinearSearch(array, -1);
            //int findIndex = BinarySearch(array, -1);
            //Console.WriteLine("탐색 결과 : {0}", findIndex);
            bool[,] graph = new bool[8, 8];
            graph[0, 1] = true;
            graph[1, 0] = true;
            graph[0, 2] = true;
            graph[2, 0] = true;
            graph[0, 4] = true;
            graph[4, 0] = true;
            graph[1, 3] = true;
            graph[3, 1] = true;
            graph[1, 5] = true;
            graph[5, 1] = true;
            graph[2, 6] = true;
            graph[6, 2] = true;
            graph[4, 7] = true;
            graph[7, 4] = true;
            graph[5, 7] = true;
            graph[7, 5] = true;
            graph[6, 7] = true;
            graph[7, 6] = true;

            //BFS 탐색
            Console.WriteLine("<BFS>");
            BFS(graph, 0, out bool[] visited, out int[] parents);
            Console.WriteLine($"{"Vertex",8}{"Visited",8}");
            for (int i = 0; i < visited.Length; i++)
            {
                Console.WriteLine($"{i,8}{visited[i],8}");
            }

            //다익스트라
            int[,] dijstra = new int[8, 8]
            {
                { 0,6,7,2,INF,INF,INF },
                {6,0,8,INF,INF,INF,2,INF},
                {7,8,0,INF,INF,2,7,INF },
                {2,INF,INF,0,INF,2,INF,INF },
                {INF,INF,INF,INF,0,INF,8,INF },
                {INF,INF,2,2,INF,0,1,1 },
                {INF,2,7,INF,8,1,0,4 },
                {INF,INF,INF,INF,INF,1,4,0 }
            };
        }
    }
}
