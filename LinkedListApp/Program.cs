﻿using DataStructures.LinkedList.SingleLinkedList;

var node1 = new SinglyLinkedListNode<char>('a');
var node2 = new SinglyLinkedListNode<char>('b');
var node3 = new SinglyLinkedListNode<char>('c');
var node4 = new SinglyLinkedListNode<char>('d');

node1.Next = node2;
node2.Next = node3;	
node3.Next = node4;

AddFirst<char>('z',ref node1); // ref. deyishikliyin globala cixarilmasi ucen 'ref keyword-u ist. ol.'
AddLast<char>('y', node1);
Traverse<char>(node1);

Console.ReadKey();

static void Traverse<T>(SinglyLinkedListNode<T> Head)
	
{
	if(Head == null)
		throw new ArgumentNullException(nameof(Head));	
	var current = Head;
	while(current != null)
	{
		Console.WriteLine(current.Value);
		current = current.Next;
	}
}
static void AddFirst<T>(T value, ref SinglyLinkedListNode<T> Head)
{
	if (Head is null)
		throw new ArgumentNullException(nameof(Head));
	var newNode = new SinglyLinkedListNode<T>(value);
	newNode.Next = Head;
	Head = newNode;
}
static void AddLast<T>(T value, SinglyLinkedListNode<T> Head)
{
	var newNode=new SinglyLinkedListNode<T>(value);
	var current = Head;
	while (current.Next != null)
	{
		current=current.Next;
	}
	current.Next = newNode;
	return;
}





