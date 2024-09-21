namespace Recursive_Depth_First_Search
{
    public class Program
    {
        // the depth first print done recursively
        public static void RecursivedepthFirstPrint(Dictionary<string, List<string>> graph, string src)
        {
            Console.WriteLine(src);
            // gets the neighbours of the source node
            List<string> neighbours = graph.GetValueOrDefault(src);

            // iterates through the neighbours and recursively calls the method
            foreach (string neighbour in neighbours)
            {
                RecursivedepthFirstPrint(graph, neighbour);
            }
        }

        static void Main(string[] args)
        {
            // key is the node
            // value is the list of neighbours of the node (list of other nodes)
            Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>
            {
                {"a",new List<string>{"b","c" } },
                {"b", new List<string>{"d"} },
                {"c",new List<string>{"e"} },
                {"d",new List<string>{} },
                {"e",new List<string>{} },
            };

            RecursivedepthFirstPrint(graph, "a");
        }
    }
}
