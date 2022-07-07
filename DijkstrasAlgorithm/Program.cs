
//Each segment has travel time in minutes.
//Use Dijkstra's algo to go from start to finish in the shortest possible time
// each edge in the graph has a weighted value
// only works on graphs with no cycles and or a positive weight` ccvb 




//Update the costs of the neighbor's node

//Repeat for every node in the graph

//calculate the final path

using DijkstrasAlgorithm;
using System.Data;

var graph = new Graph();
graph.AddNode("start", "a", 6);
graph.AddNode("start", "b", 2);
graph.AddNode("a", "fin", 1);
graph.AddNode("b", "a", 3);
graph.AddNode("fin");

var costs = new Dictionary<string, float>();
costs.Add("a", 6);
costs.Add("b", 2);
costs.Add("fin", float.PositiveInfinity);

var parents = new Dictionary<string, string>();
parents.Add("a", "start");
parents.Add("b", "start");
parents.Add("fin", String.Empty);

var processed = new List<KeyValuePair<string, float>>();
var lowestCostNode = FindLowestCost(costs, processed);


while (processed.Count < costs.Count())
{
    var cost = lowestCostNode.Value;
    var neigbors = graph[lowestCostNode.Key];
    foreach(var n in neigbors.Keys)
    {
        var newCost = cost + neigbors[n];
        if(costs[n] > newCost)
        {
            costs[n] = newCost;
            parents[n] = lowestCostNode.Key;
        }
    }
    processed.Append(lowestCostNode);
    lowestCostNode = FindLowestCost(costs, processed);

}

static KeyValuePair<string, float> FindLowestCost(Dictionary<string, float> costs, List<KeyValuePair<string, float>> processed)
{
    var lowestCost = float.PositiveInfinity;
    KeyValuePair<string, float> cheapestNode = new();
    

    foreach (var co in costs)
    {
        if(co.Value < lowestCost && !processed.Contains(co))
        {
            lowestCost = co.Value;
            cheapestNode = co;
        }
    }
    return cheapestNode;
}

