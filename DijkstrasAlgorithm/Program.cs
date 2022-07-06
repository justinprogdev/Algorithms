
//Each segment has travel time in minutes.
//Use Dijkstra's algo to go from start to finish in the shortest possible time
// each edge in the graph has a weighted value
// only works on graphs with no cycles and or a positive weight` ccvb 


//Find the cheapest node

//Update the costs of the neighbor's node

//Repeat for every node in the graph

//calculate the final path

using System.Data;

var graph = new Dictionary<string, Dictionary<string,int>>();

var startNode = new Dictionary<string, int>();
startNode.Add("a", 6);
startNode.Add("b", 2);

graph.Add("start",startNode);
Console.WriteLine(graph["start"]["a"]);
Console.WriteLine(graph["start"]["b"]);
Console.ReadLine();
