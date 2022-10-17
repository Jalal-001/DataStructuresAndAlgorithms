var _queue = new Queue<ToDo>();
_queue.Enqueue(new ToDo()
{
    Time=1,
    Describe="School"
});
_queue.Enqueue(new ToDo()
{
    Time = 1,
    Describe="Breakfast"
});
_queue.Enqueue(new ToDo()
{
    Time=3,
    Describe="Exam"
});

var result=_queue.Dequeue();

Console.WriteLine(result.Describe + " --- Done");

Console.WriteLine(_queue.Count);

foreach (var item in _queue)
{
    Console.WriteLine(item);
}
