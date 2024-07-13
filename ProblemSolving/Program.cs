using System.Security.AccessControl;
using LeetCode.Easy;
using LeetCode.Medium;
using Sheet.A;

using customNode = LeetCode.Easy;

/* Test Cases:
{"jbboxe","yshcrtanrtlzyyp","vudsssnzuef","lde"};
{"jbboxeyshcrtanrt","lzyypvudsssnzueflde"};

*/


string[] word1 = {"jbboxe","yshcrtanrtlzyyp","vudsssnzuef","lde"};
string[] word2 = {"jbboxeyshcrtanrt","lzyypvudsssnzueflde"};

// string str = "acfbe";

// Array.Sort(str.ToCharArray());


// Console.WriteLine(str);


Console.WriteLine(CheckIfTwoStringArraysAreEquivalent.Solution(word1, word2));


