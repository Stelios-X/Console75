using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class EncodeDecode
    {
        /*
         * Time Complexity O(N), where N is the total length of the input strings.
         * The methods involve iterating through the strings or the encoded string once.
         * 
         * Space Complexity  for encoding is O(N), where N is the total length of the input strings. This is due to the joined string.
           The space complexity for decoding is O(N), where N is the total length of the encoded string. 
           This is due to the split string array.
         * 
         * Design an algorithm to encode a list of strings to a single string and decode a string to a list of strings. 
         * The encoding rule is as follows: The input list is compressed into a single string, where 
         * each original string is followed by a marker # and its length. The markers are used to separate the original strings 
         * when decoding.
         * 
         * The Encode method joins the strings using a delimiter (\0) that is unlikely to appear in the strings.
           The Decode method splits the encoded string using the delimiter and adds non-empty strings to the list.
         * 
         */

        //Encoding a list of strings to a single string
        public string Encode(List<string> strs) 
        {
            //Join the strings using a delimiter that is unlikely to appear in the strings
            return string.Join("\0", strs);
        }


        //Decode a single string to a list of strings
        public List<string> Decode(string s) 
        {
            List<string> decoded = new List<string>();

            //Split the strings using the delimiter
            string[] parts = s.Split('\0');

            //Add non-empty strings to the list
            foreach (string part in parts) 
            {
                if (!string.IsNullOrEmpty(part)) 
                {
                    decoded.Add(part);
                }
            }
            return decoded;
        }
    }
}
