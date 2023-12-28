using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class WordDictionary
    {
        /*
         * Time Complexity of AddWord is O(m), where m is the length of the word being added. & the time complexity of Search is O(n), 
         * where n is the total number of nodes in the trie.
         * 
         * Space Complexity of Search is  O(N * M), where N is the number of words and M is the average length of the words.
         * 
         * Design a data structure that supports adding new words and finding if a string matches any previously added strings.

           Implement the WordDictionary class:

           WordDictionary() Initializes the object.
           void addWord(word): Adds word to the data structure, it can be matched later.
           bool search(word): Returns true if there is any string in the data structure that matches word or false otherwise. 
           A word may contain dots '.' where dots can be matched with any letter.
         * 
         * The code uses a trie (prefix tree) data structure to efficiently store and search for words.
           The WordDictionary class has methods for adding words (AddWord) and searching for words (Search).
           The TrieNode class represents a node in the trie.
           The Search method handles the case when the search word contains dots ('.'), allowing for wildcard matching.
           The SearchRecursive helper method is a recursive function used to traverse the trie while handling wildcard characters.
           The examples demonstrate the usage of the WordDictionary with different operations.
         */

        private TrieNode root;
        
        public WordDictionary() 
        {
            root = new TrieNode();
        }

        public void AddWord(string word) 
        {
            TrieNode node = root;
            foreach (char c in word) 
            {
                int index = c - 'a';
                if (node.Children[index] == null) 
                {
                    node.Children[index] = new TrieNode();
                }
                node = node.Children[index];    
            }
            node.IsEndOfWord = true;

        }

        public bool Search(string word) 
        {
            return SearchRecursive(word, root, 0);
        }

        private bool SearchRecursive(string word, TrieNode node, int index) 
        {
            if (index == word.Length) 
            {
                return node.IsEndOfWord;
            }

            char c = word[index];
            if (c == '.')
            {
                //If the character is '.' try matching with any child
                foreach (TrieNode child in node.Children)
                {
                    if (child != null && SearchRecursive(word, child, index + 1))
                    {
                        return true;
                    }
                }
                return false;
            }
            else 
            {
                int charIndex = c - 'a';
                if (node.Children[charIndex] == null) 
                {
                    return false;   //No match found
                }
                return SearchRecursive(word, node.Children[charIndex], index + 1);
            }
        }


    }
}
