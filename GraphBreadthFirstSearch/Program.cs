// See https://aka.ms/new-console-template for more information

//This is based on memory of a recent amazon test that thoroughly kicked my ass

// We receive a list of user transactions. 
// 1. Each transaction has the following values in one string NOT an array. (horrible I know)
// sender_id, receiver_id, transaction_amount

// 2. We receive a threshold parameter. If any user has number of transactions greater then the threshold, we record their user id and return it in a list

// 3. If a user is on both side of transaction (sender and receiver) we don't count it. 

//SO transactions 0 and 1 should only count as on transx for both users. 
var transactions = new List<string>() { "1 2 300", "2 1 300", "1 10 500" };

var result = GetTransactionsOverThreashold(transactions);
var end = 0;
static List<string> GetTransactionsOverThreashold(List<string> transactions)
{

    // First thing, I think I need to get the data to a dict for easy access
    var arr = new List<string[]>();
    foreach (var trans in transactions)
    {
        var i = trans.Split(' ');
        arr.Append(i);
    }

    //Now I will check transactions of each user in queue
    for (int i = 0; i < arr.Count(); i++)
    {
        var user = arr[i];

        for (int j = 0; j < arr.Count(); j++)
        {
            var user2 = arr[j];
            if (user != user2) { continue; }



        }
    }



    return new List<string>();
}
