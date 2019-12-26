using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practice.Classlibrary
{
    public class Tests
    {
        public void LongestSubstring()
        {
            string s1 = "geeksforgeeks";
            string s2 = "abcgeeksyz";

            string common = "";
            for (int skipChars = 1; skipChars <= s2.Length; skipChars++)
            {
                int lastIndex = s2.Length - skipChars;

                for (int pos = 0; pos < s2.Length - skipChars; pos++)
                {
                    //left
                    string l = s2.Substring(0, pos + skipChars - 1);

                    //right
                    string r = s2.Substring(pos + skipChars , s2.Length - pos - skipChars );
                }
            }
        }

        string removeLeft(String s, int charCount)
        {

            return s.Substring(charCount);
        }

        string removeRight(String s, int charCount)
        {
            return s.Substring(0, s.Length - charCount);
        }

        string removeBoth(String s, int charCount)
        {
            var temp = removeLeft(s, charCount);
            return removeRight(temp, charCount);
        }

        string removeBoth(String s, int l, int r)
        {
            var temp = removeLeft(s, l);
            return removeRight(temp, r);
        }

        public void GetLongestSString()
        {
            String s1 = "ADSERFS";
            String s2 = "BATZRFB";

            String source = s2;

            if (s1.Contains(source))
            {
                Console.WriteLine("String:" + source);
                return;
            }

            int i = 1;
            while (!s1.Contains(source) && s2.Length - (i * 2) >= 1)
            {

                source = removeLeft(s2, i);
                if (s1.Contains(source))
                {
                    break;
                }

                source = removeRight(s2, i);
                if (s1.Contains(source))
                {
                    break;
                }

                for (int j = 1; j <= i && !s1.Contains(source); j++)
                {

                    for (int k = 1; k <= j; k++)
                    {
                        source = removeBoth(s2, j, k);
                        if (s1.Contains(source))
                        {
                            break;
                        }

                        source = removeBoth(s2, k, j);
                        if (s1.Contains(source))
                        {
                            break;
                        }
                    }

                }


                int[] ints = { -9, 1, 2 };

                ints.ToList().Sort();

            }

            Console.WriteLine("String:" + source);

        }

        class Answer
        {
            /// Filters the​​​​​​‌​​​‌​​‌​‌‌​​​​‌‌​‌​​​‌​​ strings
            public IEnumerable<string> Filter(List<string> strings)
            {
                strings.Sort();

                foreach (string s in strings)
                {
                    if (s.ToLower()[0] == 'l')
                        yield return s;
                }


            }
        }

        public void Test()
        {

            int[] ints = { -9, 8, -5, 5, 7 };

            var mn = ints.Where(x => x >= 0).ToList().Min();
            var mx = ints.Where(x => x < 0).ToList().Max();

            if (mx * -1 < mn)
            {
                //mx;
            }
            else
            {
                //mn
            }


            List<int> stones = new List<int> { 1, 1, 2, 2, 3, 3 };

            int dupLen = 0;
            do
            {
                var dup = stones.GroupBy(s => s)
                    .Where(x => x.Count() > 1)
                    .Select(s => new { a = s.Key, b = s.Count() }).ToList();

                dupLen = dup.Count();

                stones.RemoveAll(x => dup.Select(y => y.a).ToList().Contains(x));

                foreach (var s in dup)
                {
                    int ns = s.a * s.b;
                    stones.Add(ns);
                }

            } while (dupLen > 0);

            stones.Count();

            //from s in stones
            //group s by s into sg
            //select new { v= sg.Key,c= sg.Count()} ;

            var d = new DateTime(0);
            d.AddHours(2);
            Console.Write(d.Hour);

            var strings = new List<string>();
            var filteredStrings = new Answer().Filter(strings);

            strings.Add("Gurt");
            strings.Add("Lobster");
            strings.Add("Litch");
            strings.Add("Doe");

            foreach (var str in filteredStrings)
            {
                Console.WriteLine(str);
            }
        }


        public void GetLargestring()
        {
            String s1 = "ADSERFS";
            String s2 = "ASERD";

            String greatestMatch = s2;

            bool isContains = s1.Contains(s2);


            if (isContains)
            {
                Console.WriteLine("greatest mached string:" + greatestMatch);
            }
            else
            {

                int charToSkip = 1;

                do
                {
                    //Skipping char
                    for (int i = 0; i < greatestMatch.Length; i++)
                    {
                        int index = i + charToSkip;

                        String matched = greatestMatch.Substring(index, greatestMatch.Length - index);

                        isContains = s1.Contains(matched);


                        if (isContains)
                        {
                            greatestMatch = matched;
                        }
                    }

                    charToSkip++;
                } while (!isContains);


                Console.WriteLine("greatest mached string:" + greatestMatch);

            }






        }
    }
}
