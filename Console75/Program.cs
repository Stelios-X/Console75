// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using Console75;

//Test Case
//ListNode edges = '1-> 2 -> 3 -> 4 -> 5';
string[] t = ["eat", "tea", "tan", "ate", "nat", "bat"];
string s = "racecar";


SerializeDeserialize ed = new SerializeDeserialize();
// Example 1
TreeNode tree1 = new TreeNode(1)
{
    left = new TreeNode(2),
    right = new TreeNode(3)
    {
        left = new TreeNode(4),
        right = new TreeNode(5)
    }
};
string serializedTree1 = ed.serialize(tree1);
Console.WriteLine("Example 1 (Serialized): " + serializedTree1);
TreeNode deserializedTree1 = ed.deserialize(serializedTree1);
Console.WriteLine("Example 1 (Deserialized): " + ed.serialize(deserializedTree1));
Console.WriteLine();


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
