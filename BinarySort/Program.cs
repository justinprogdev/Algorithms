// See https://aka.ms/new-console-template for more information


var myList = new List<int> { 1, 3, 5, 7, 9, 15, 20, 25, 26, 29, 30, 32, 33, 39, 100, 150, 151, 152 };
Console.WriteLine(BinarySearch(myList, 3));
Console.ReadLine();

static int BinarySearch(List<int> unsorted, int item)
{
    var low = 0;
    var high = unsorted.Count() - 1;

    while (low <= high)
    {
        //Guess the middle element
        var mid = (int)((low + high) / 2);
        var guess = unsorted[mid];

        //If the guess is the item we're done (base case)
        if (guess == item)
        {
            return mid;
        }
        //If guess is high, cut results in half
        else if (guess > item)
        {
            high = mid - 1;
        }
        //If too low, raise low up.
        else { low = mid + 1;}
    }

    return -1;
}