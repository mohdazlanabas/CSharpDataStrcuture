using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;

namespace TrieFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] keys = { "the", "a", "there", "answer", "any", "by", "bye", "their" };
            String[] output = { "Not present in trie", "Present in trie" };
            root = new TrieNode();
            int i;
            for (i = 0; i < keys.Length; i++)
            {
                insert(keys[i]);
            }
            if (search("the") == true) // the
            {
                Console.WriteLine("the ---" + output[1]);
            }
            else
            {
                Console.WriteLine("the ---" + output[0]);
            }
            if (search("these") == true) // these
            {
                Console.WriteLine("these ---" + output[1]);
            }
            else
            {
                Console.WriteLine("these ---" + output[0]);
            }
            if (search("their") == true) //their
            {
                Console.WriteLine("their ---" + output[1]);
            }
            else
            {
                Console.WriteLine("their ---" + output[0]);
            }
            if (search("thaw") == true) // thaw
            {
                Console.WriteLine("thaw ---" + output[1]);
            }
            else
            {
                Console.WriteLine("thaw ---" + output[0]);
            }
        }
        // MAIN END
        static readonly int ALPHABET_SIZE = 26;
        class TrieNode
        {
            public TrieNode[] children = new TrieNode[ALPHABET_SIZE];
            public bool isEndOfWord;
            public TrieNode()
            {
                isEndOfWord = false;
                for (int i = 0; i < ALPHABET_SIZE; i++)
                {
                    children[i] = null;
                }
            }
        };
        // CLASS TRINODE END

        static TrieNode root;

        static void insert(String key)
        {
            int level;
            int length = key.Length;
            int index;
            TrieNode pCrawl = root;
            for (level = 0; level < length; level++)
            {
                index = key[level] - 'a';
                if (pCrawl.children[index] == null)
                    pCrawl.children[index] = new TrieNode();

                pCrawl = pCrawl.children[index];
            }
        }
        // INSERT END

        static bool search(String key)
        {
            int level;
            int length = key.Length;
            int index;
            TrieNode pCrawl = root;
            for (level = 0; level < length; level++)
            {
                index = key[level] - 'a';
                if (pCrawl.children[index] == null)
                    return false;
                pCrawl = pCrawl.children[index];
            }
            return (pCrawl.isEndOfWord);
        }

    // SEARCH END
    }
}
