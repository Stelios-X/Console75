// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using Console75;

//Test Case
//ListNode edges = '1-> 2 -> 3 -> 4 -> 5';
int[][] page = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
string x = "bbbbb";

LongestSubString longestSubString = new LongestSubString();
//longestSubString.LongestSubStringSol(x);

//string[] wordDictNew = {"leet","code"};

RotateImage sm = new RotateImage();

var xx = longestSubString.LongestSubStringSol(x);

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


/*
int[][] matrix1 = {
            new int[] {1,2,3},
            new int[] {4,5,6},
            new int[] {7,8,9}
        };
sm.RotateImageSol(matrix1);
PrintMatrix(matrix1);*/
