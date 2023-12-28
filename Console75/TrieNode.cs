using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class TrieNode
    {
        public bool IsEndOfWord;
        public TrieNode[] Children;

        public TrieNode() 
        {
            IsEndOfWord = false;
            Children = new TrieNode[26]; //Assuming only lowercase English letters
        }
    }
}
