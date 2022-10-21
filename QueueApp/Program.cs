using DataStructures.Queue;
using Queue;

var _queue = new DataStructures.Queue.Queue<ToDo>(QueueType.ArrayQueue);
_queue.EnQueue(new ToDo()
{
    Time=1,
    Describe="School"
});
_queue.EnQueue(new ToDo()
{
    Time = 1,
    Describe="Breakfast"
});
_queue.EnQueue(new ToDo()
{
    Time=3,
    Describe="Exam"
});

var result=_queue.DeQueue();

Console.WriteLine(result.Describe + " --- Done");

Console.WriteLine(_queue.Count);

foreach (var item in _queue)
{
    Console.WriteLine(item);
}
