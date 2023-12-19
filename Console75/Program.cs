// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using Console75;

//Test Case
int[][] edges = [[1, 2], [2, 3]];
int[] page = [2, 5];
int x = 5;

//string[] wordDictNew = {"leet","code"};

NonOverlapIntervals nonOverlapIntervals = new NonOverlapIntervals();  
var xx = nonOverlapIntervals.EraseOverlapInt( edges);

Console.WriteLine(xx.ToString());


//var res = combiSum.CombiSumSol(numz, target);

/*
xx.ToString();
foreach (var item in xx) 
{
    Console.Write($" ==>{item}");
}
*/
//var ans = 
