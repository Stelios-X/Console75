// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using Console75;

//Test Case
//ListNode edges = '1-> 2 -> 3 -> 4 -> 5';
string[] t = ["eat", "tea", "tan", "ate", "nat", "bat"];
string s = "racecar";


AncestorBinarySearch ed = new AncestorBinarySearch();
// Example 1
TreeNode tree1 = new TreeNode(6)
{
    left = new TreeNode(2)
    {
        left = new TreeNode(0),
        right = new TreeNode(4)
        {
            left = new TreeNode(3),
            right = new TreeNode(5)
        }
    },
    right = new TreeNode(8)
    {
        left = new TreeNode(7),
        right = new TreeNode(9)
    }
};
TreeNode p1 = tree1.left;
TreeNode q1 = tree1.right;
Console.WriteLine("Example 1: " + ed.LowestCommonAncestor(tree1, p1, q1).val);

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
