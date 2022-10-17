using Stack;

string msg = "Selam";
//Default => StackType.LinkedListStack
var stack=new Stack.Stack<char>(Stack.Stack<char>.StackType.ArraySatck);
for (int i = 0; i < msg.Length; i++)
{
    stack.Push(msg[i]);
}
var n = stack.Count;
for (int i = 0; i < n; i++)
{
    Console.WriteLine(stack.Pop());    
}