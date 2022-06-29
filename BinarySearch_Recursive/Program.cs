// See https://aka.ms/new-console-template for more information


var myList = new List<int> { 1, 3, 5, 7, 9, 15, 20, 25, 26, 29, 30, 32, 33, 39, 100, 150, 151, 152, 153 };

Console.WriteLine(BinarySearch(myList, 151));
Console.ReadLine();

static int BinarySearch(List<int> list, int item)
{
    if ((list == null))
    {
        return -1;
    }

    var low = 0;
    var high = list.Count - 1;

    //Check the middle element
    var mid = (int)(low + high) / 2;
    var guess = list[mid];


    //Base case
    if (guess == item)
    {
        return guess;
    }
    //If guess is too high
    if (guess > item)
    {
        var indexCount = 0;
        for (int i = 0; i < mid; i++)
        {
            indexCount += 1;
        }
        //remove the higher item from list
        return BinarySearch(list.GetRange(0, indexCount), item);
    }
    //if guess is too low remove lower item from list
    else
    {
        var indexCount = 0;
        for (int i = mid + 1; i < list.Count(); i++)
        {
            indexCount += 1;
        }
        return BinarySearch(list.GetRange(mid + 1, indexCount), item);
    }
}
