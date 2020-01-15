using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace AnagramKata
{
    public class AnagramSelector
    {
        public List<string> Group(List<string> words)
        {            

            return new List<string>();
        }

        public bool AreAnagrams(string first, string second)
        {
            //1. 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 
            //101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199.
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                {'A', 2 },
                {'B', 3 },
                {'C', 5 },
                {'D', 7 },
                {'E', 11 },
                {'F', 13 },
                {'G', 17 },
                {'H', 19 },
                {'I', 23 },
                {'J', 29 },
                {'K', 31 },
                {'L', 37 },
                {'M', 41 },
                {'N', 43 },
                {'O', 47 },
                {'P', 53 },
                {'Q', 59 },
                {'R', 61 },
                {'S', 67 },
                {'T', 71 },
                {'U', 73 },
                {'V', 79 },
                {'W', 83 },
                {'X', 89 },
                {'Y', 97 },
                {'Z', 101 }
            };

            if(first.Length!=second.Length || first == second)
                return false;

            ulong firstProduct = 0;
            ulong secondProduct = 0;

            for(int i=0; i<first.Length; i++)
            {
                firstProduct *= (ulong)map[first[i]];
                secondProduct *= (ulong)map[second[i]];
            }

            return firstProduct == secondProduct;
        }
    }
}
