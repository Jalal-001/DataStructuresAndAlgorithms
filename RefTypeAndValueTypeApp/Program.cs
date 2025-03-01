﻿using ReferenceTypeAndValueType;
using ValueType = ReferenceTypeAndValueType.ValueType;

//Reference Type

var p1 = new ReferenceType { X = 10, Y = 20 };
var p2 = p1;
p2.X = 30;
Console.WriteLine($"P1: {p1.X} {p1.Y}");
Console.WriteLine($"P2: {p2.X} {p2.Y}");
int a = 7, b = 8;

//p1.Swap(ref a, ref b);
//Console.WriteLine($"Swap: {a} {b}");

//Value Type

var p3 = new ValueType() { X = 10, Y = 20 };
var p4 = p3;
p4.X = 30;
Console.WriteLine($"P1: {p3.X} {p3.Y}");
Console.WriteLine($"P2: {p4.X} {p4.Y}");