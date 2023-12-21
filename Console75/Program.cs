// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using Console75;

//Test Case
//ListNode edges = '1-> 2 -> 3 -> 4 -> 5';
int[][] page = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
//int x = 5;

//string[] wordDictNew = {"leet","code"};

SpiralMatrix sm = new SpiralMatrix();

var xx = sm.SpiralMatrixSol( page);

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
