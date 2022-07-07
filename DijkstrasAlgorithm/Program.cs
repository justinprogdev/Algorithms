
//Each segment has travel time in minutes.
//Use Dijkstra's algo to go from start to finish in the shortest possible time
// each edge in the graph has a weighted value
// only works on graphs with no cycles and or a positive weight` ccvb 


//Find the cheapest node

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

