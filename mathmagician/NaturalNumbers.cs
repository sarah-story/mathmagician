using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathmagician
{
    public class NaturalNumbers
    {
        protected int first;

        public NaturalNumbers()
        {
            first = 1;
        }

        public int GetFirst()
        {
            return first;
        }

        public virtual int GetNext(int x)
        {
            return x+1;
        }

        public int[] GetSequence()
        {
            return GetSequence(10);
        }

        public int[] GetSequence(int length)
        {
            List<int> output = new List<int>();
            output.Add(GetFirst());
            while (output.Count() < length)
            {
                output.Add(GetNext(output.Last()));
            }
            return output.ToArray();
        }

        public string ToString(int[] sequence)
        {
            string output = string.Join(" ", sequence);
            return output;
        }
    }
}
