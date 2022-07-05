
//BFS is an algorithm you can run on graphs to answer questions like:

//  "Is there a path from x to y?" (Is there a mango seller in your nerwork?"
//  "What is the shortest path to go for X?" "who is the mango seller"

var hashTable = new Dictionary<string, string[]>();

//1. Make a graph from adding relationships to a dictionary/hash table
hashTable.Add("you", new string[] { "alice", "bob", "claire" });
hashTable.Add("bob", new string[] { "anuj", "peggy"});
hashTable.Add("alice", new string[] { "peggy" });
hashTable.Add("claire", new string[] { "thom", "johnny" });
hashTable.Add("anuj", new string[] {});
hashTable.Add("peggy", new string[] {});
hashTable.Add("thom", new string[] {});
hashTable.Add("johnny", new string[] {});

//2. Make a queue to keep order of which people/paths we have checked. 
// in this case we can use a queue of string, as we're only temp storing the name.

// O(V + E)
var searchQueue = new Queue<string>();
searchQueue.Enqueue("you");


while( searchQueue.Count > 0)
{
    var user = searchQueue.Dequeue();
    if (IsUserMangoSeller(user))
    {
        Console.WriteLine($"{user} is a mango seller");
    }
    else
    {
        foreach(var u in hashTable[user])
        {
            searchQueue.Enqueue(u);
        }
        
    }
}


//In the example, thom is the mango seller
static bool IsUserMangoSeller(string user)
{
    return user.Contains("m");
}



