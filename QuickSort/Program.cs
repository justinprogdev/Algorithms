// See https://aka.ms/new-console-template for more information



List<int>? l = QuickSort(new List<int> {5,2,3,4,5,6,1,09,90,9000,123,342,53,8769,754,34566,3322,
908520398,289375,23756,234,534,235,35,5432,54,3,78,23,1,19,90,45,341,890,8900,99,98,97,96,95,94,93,92,91,90,21,22,23,24,25,26,
27,28,30,31,32,33,34,35,36,37,38,39,987,876,765,654,543,430}).Distinct().ToList();

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

    //Get items less than pivot
    List<int>? less = list.Where(x => x < pivot).ToList();

    //Get items greater than pivot
    List<int>? greater = list.Where(x => x > pivot).ToList();

    //Recursively call sort and place them in order
    // return new array [less than pivot, pivot, greater than pivot]
    //I hadn't seen this in C# before. In python you just concatenate the arrays. Here I had to get funky
    List<int>? newList = new List<int>();
    newList.AddRange(QuickSort(less));
    newList.Insert(newList.Count, pivot);
    newList.InsertRange(newList.Count(), QuickSort(greater));
    return newList;

}