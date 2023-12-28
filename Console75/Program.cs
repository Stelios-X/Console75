// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using Console75;

//Test Case
//ListNode edges = '1-> 2 -> 3 -> 4 -> 5';
string[] t = ["eat", "tea", "tan", "ate", "nat", "bat"];
string s = "racecar";


WordSearchII wordSearch = new WordSearchII();

// Example 1
char[][] board1 = {
            new char[] { 'o', 'a', 'a', 'n' },
            new char[] { 'e', 't', 'a', 'e' },
            new char[] { 'i', 'h', 'k', 'r' },
            new char[] { 'i', 'f', 'l', 'v' }
        };
string[] words1 = { "oath", "pea", "eat", "rain" };
IList<string> result1 = wordSearch.FindWords(board1, words1);
Console.WriteLine("Example 1: " + string.Join(", ", result1));

//longestSubString.LongestSubStringSol(x);

//string[] wordDictNew = {"leet","code"};

//RotateImage sm = new RotateImage();

//var xx = ps.PalindromicSubstringSol(s);

//Console.WriteLine(xx.ToString());
//Console.WriteLine(xx.ToString());


//var res = combiSum.CombiSumSol(numz, target);


//xx.ToString();
/*foreach (var item in xx) 
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
