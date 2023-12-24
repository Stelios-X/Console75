using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class GroupAnagram
    {
        /*
        * Time Complexity O(N * K * log(K)), where N is the number of strings and K is the maximum length of a string.
        * This is because, for each string, the code sorts its characters, and sorting has a time complexity of O(K * log(K)).
        * 
        * Space Complexity O(N * K), where N is the number of strings and K is the maximum length of a string. 
        * This is because the code uses a dictionary to store anagram groups, and each group may have a key of length K.
        * 
        * Given an array of strings, group anagrams together. An anagram is a word or phrase formed by rearranging 
        * the letters of a different word or phrase, typically using all the original letters exactly once.
        * 
        * The code uses a dictionary (anagramGroups) to group anagrams based on their sorted representations.
          For each string in the array, it sorts the characters, creating a key for the anagram group.
          The original string is then added to the corresponding group in the dictionary.
          Finally, the values of the dictionary (the anagram groups) are converted to a list of lists.
        */
        public IList<IList<string>> GroupAnagramSol(string[] strs) 
        {
            if (strs.Length == 0) 
            {
                return new List<IList<string>>();
            }

            Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {
                //Convert each string to a char array, sort it and create a key
                char[] charArray = str.ToCharArray();
                Array.Sort(charArray);
                string key = new string(charArray);

                //Add the string to the corresponding group
                if (!anagramGroups.ContainsKey(key)) 
                {
                    anagramGroups[key] = new List<string>();
                }
                anagramGroups[key].Add(str);
            }
            //Convert the values of the dictionary to a list of lists
            return new List<IList<string>>(anagramGroups.Values);
        }
    }
}
