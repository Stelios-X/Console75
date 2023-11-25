// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using Console75;

//Test Case
int[] nums = { -1,1,0,-3,3};

SelfProduct selfProduct = new SelfProduct();
int[] arr = selfProduct.SelfProductSol(nums);
foreach (var item in arr) 
{
    Console.Write($" ==>{item}");
}

//var ans = 