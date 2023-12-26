// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using Console75;

//Test Case
//ListNode edges = '1-> 2 -> 3 -> 4 -> 5';
string[] t = ["eat", "tea", "tan", "ate", "nat", "bat"];
string s = "racecar";


SameTree ed = new SameTree();

TreeNode tree3 = new TreeNode(1)
{
    left = new TreeNode(2),
    right = new TreeNode(1)
};
TreeNode tree4 = new TreeNode(1)
{
    left = new TreeNode(1),
    right = new TreeNode(2)
};
bool result2 = ed.SameTreeSol(tree3, tree4);
Console.WriteLine("Example 2: " + result2);
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
