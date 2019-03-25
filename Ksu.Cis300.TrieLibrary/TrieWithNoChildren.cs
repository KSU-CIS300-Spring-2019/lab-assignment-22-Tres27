using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    public class TrieWithNoChildren : ITrie
    {
        private bool _emptystring = false;

        public ITrie Add(string s)
        {
            if (s == "")
            {
                _emptystring = true;
            }
            if(s == "" || s[0] < 'a' || s[0] > 'z')
            {
                throw new ArgumentException();
            }

        }
        public bool Contains(string s)
        {
            if(s == "") { return _emptystring; }
            return false;
        }
    }
}
