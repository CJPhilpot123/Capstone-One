using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneOnePigLatin
{
    class Guinea
    {
        public static string Aye(string words)
        {
            char[] coal = words.ToCharArray();
            char[] V = { 'a', 'e', 'i', 'o', 'u' };
            const string VL = "aeiou";
            List<string> New = new List<string>();
            int L = coal.Length;
            if (coal[0] == V[0] || coal[0] == V[1] || coal[0] == V[2] || coal[0] == V[3] || coal[0] == V[4])
            {
                return $"{words}way";

            }

            foreach (string word in words.Split(' '))
            {
                string One = word.Substring(0, 1);
                string Two = word.Substring(0, 2);
                string Three = word.Substring(0, 3);

                string small = word.Substring(1);


                string rest = word.Substring(1, L - 1);
                string restwo = word.Substring(2, L - 2);
                string resthree = word.Substring(3, L - 3);


                int current = VL.IndexOf(One);
                int currentwo = VL.IndexOf(Two);
                int currenthree = VL.IndexOf(Three);


                if (coal[1] == V[0] || coal[1] == V[1] || coal[1] == V[2] || coal[1] == V[3] || coal[1] == V[4])
                {
                    New.Add(rest + One + "ay");
                    break;
                }
                if (coal[2] == V[0] || coal[2] == V[1] || coal[2] == V[2] || coal[2] == V[3] || coal[2] == V[4])
                {
                    New.Add(restwo + Two + "ay");
                    break;
                }
                if (coal[3] == V[0] || coal[3] == V[1] || coal[3] == V[2] || coal[3] == V[3] || coal[3] == V[4])
                {
                    New.Add(resthree + Three + "ay");
                    break;
                }
            }
            return string.Join(" ", New);

        }
    }
}
