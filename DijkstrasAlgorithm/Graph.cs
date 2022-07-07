namespace DijkstrasAlgorithm
{
    internal class Graph
    {
        public Dictionary<string, Dictionary<string, int?>> Nodes { get; private set; }

        public Graph()
        {
            Nodes = new Dictionary<string, Dictionary<string,int?>>();
        }

        public void AddNode(string key1, string key2, int? value)
        {

            if (Nodes.TryGetValue(key1, out _))
            {
                Nodes[key1].Add(key2, value);
            }
            else
            {
                var node = new Dictionary<string, int?>();
                node.Add(key2, value);
                Nodes.Add(key1, node);
            }
        }


        internal void AddNode(string value)
        {
            var finish = new Dictionary<string, int?>();
            Nodes.Add(value, finish);
        }

        public Dictionary<string, int?> this[string index]
        {
            get
            { 
                return Nodes[index]; 
            }
        }
    }
}
