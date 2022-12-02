using DataStructures.Array;

// system array

var arr = System.Array.CreateInstance(typeof(int),4);
arr.SetValue(11, 0);
arr.SetValue(22, 1);
arr.SetValue(33, 2);
arr.SetValue(44, 3);

Console.WriteLine(arr.GetValue(0));
try
{
    Console.WriteLine(arr.GetValue(4));

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
foreach (var item in arr)
{
    Console.WriteLine(item);
}

// our array

var ownArray = new DataStructures.Array.Array(1, 2, 3);
foreach (var item in ownArray)
{
    Console.WriteLine(item);
}

var arrayList = new ArrayList();
for (int i = 0; i < 50; i++)
{
 arrayList.Add(i);
    Console.WriteLine(i);
}

Console.ReadKey();