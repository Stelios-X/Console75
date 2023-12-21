// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using Console75;

//Test Case
int[][] edges = [[7, 10], [2, 4]];
int[] page = [2, 5];
int x = 5;

//string[] wordDictNew = {"leet","code"};

MeetingRoom_II meetingRoom_I = new MeetingRoom_II(); 
var xx = meetingRoom_I.MeetingRoom_IISol( edges);

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
