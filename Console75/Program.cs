// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using Console75;

//Test Case
//ListNode edges = '1-> 2 -> 3 -> 4 -> 5';
string[] t = ["eat", "tea", "tan", "ate", "nat", "bat"];
string s = "racecar";


WordDictionary wordDict = new WordDictionary();

// Example 1
wordDict.AddWord("bad");
wordDict.AddWord("dad");
wordDict.AddWord("mad");
Console.WriteLine("Search 'pad': " + wordDict.Search("pad")); // Output: false
Console.WriteLine("Search 'bad': " + wordDict.Search("bad")); // Output: true
Console.WriteLine("Search '.ad': " + wordDict.Search(".ad")); // Output: true
Console.WriteLine("Search 'b..': " + wordDict.Search("b..")); // Output: true

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
