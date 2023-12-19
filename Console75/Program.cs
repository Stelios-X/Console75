// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using Console75;

//Test Case
int[][] edges = [[1, 3], [2, 6], [8, 10], [15, 18]];
int[] page = [2, 5];
int x = 5;

//string[] wordDictNew = {"leet","code"};

MergeInterval mergeInterval = new MergeInterval();  
var xx = mergeInterval.MergeIntervalSol( edges);

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
