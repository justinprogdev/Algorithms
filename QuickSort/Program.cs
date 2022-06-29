// See https://aka.ms/new-console-template for more information



List<int>? l = QuickSort(new List<int> { 10, 5, 2, 3 });
foreach (int i in l)
{
    Console.WriteLine(i);
}
Console.ReadLine();

static List<int> QuickSort(List<int> list)
{
    if (list.Count < 2)
        return list;
    //Pivot point 
    int pivot = list[0];

    List<int>? newList = new List<int>();
    //Get items less than pivot
    List<int>? less = list.Where(x => x < pivot).ToList();

    //Get items greater than pivot
    List<int>? greater = list.Where(x => x > pivot).ToList();

    //Recursively call sort and place them in order
    // [less than pivot, pivot, greater than pivot]
    //I hadn't seen this in C# before. In python you just concatenate the arrays. Here I had to get funky
    newList.AddRange(QuickSort(less));
    newList.Insert(newList.Count, pivot);
    newList.InsertRange(newList.Count(), QuickSort(greater));
    return newList;

}