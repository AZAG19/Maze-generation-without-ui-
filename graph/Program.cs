namespace graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 2;
            //Graph graph = new Graph(2,4);
            Graph3D graph = new Graph3D(2, 3, 2);
            //graph.DisplaySets();
            //graph.DisplayAdjecency();
            //graph.AddEdge(0, 15);
            //(int num1, int num2) = graph.GetRandomEdge();
            //graph.AddEdge(num1, num2);
            //graph.RandomisedDepthFirst();
            //graph.Kruskals();
            graph.Wilsons();
            //graph.DisplayAdjecency();
            graph.DisplayConnections();
            //graph.DepthFirstSearchSolver(0, 8);
            //graph.DisplaySoloution(graph.DepthFirstSearchSolver(0, 8));
            //graph.DisplayList(graph.nodesVisited);
            //graph.DisplaySets();
        }
    }
}