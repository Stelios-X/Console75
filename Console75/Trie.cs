using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class Trie
    {
        private TrieNode root;

        public Trie() 
        {
            root = new TrieNode(); 
        }


        public void Insert(string word)
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
            TrieNode node = SearchPrefix(word);
            return node != null && node.IsEndOfWord;
        }

        public bool StartsWith(string prefix)
        {
            return SearchPrefix(prefix) != null;
        }

        private TrieNode SearchPrefix(string prefix)
        {
            TrieNode node = root;
            foreach (char c in prefix)
            {
                int index = c - 'a';
                if (node.Children[index] == null)
                {
                    return null; //Prefix not found
                }
                node = node.Children[index];
            }
            return node;
        }

    }
}
