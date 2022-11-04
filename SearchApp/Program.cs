
using Search;

var arr = new int[] { 10, 20, 30, 40, 50, 60, 70, 80 };

//var result = BinarySearch.Search(arr,80);
var result = RecursiveBinarySearch.Search(arr, 0, arr.Length - 1, 40);


if (result != -1)
    Console.WriteLine($"arr[{result}]={arr[result]}");
else
    Console.WriteLine("Searched item not found");

