using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide5_11
{
    internal class IntCollection
    {
        private ArrayList arInts = new ArrayList();
        public int getInt(int pos) => (int)arInts[pos];
        public void AddInt(int n) => arInts.Add(n);
        public void Clear() => arInts.Clear();  
        public int Count => arInts.Count;
    }
}
