///Author: Shreyas Chaliha
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    public class TrieWithOneChild : ITrie
    {
        private bool _emptystr;
        private ITrie _onlychild;
        private char _childlabel;

        public TrieWithOneChild(string str, bool emptystr)
        {
            if(str == "" || str[0] < 'a' || str[0] > 'z')
            {
                throw new ArgumentException();
            }
            _emptystr = emptystr;
        }

        public ITrie Add(string s)
        {
            if (s == "")
            {
                _emptystr = true;
                return this;
            }
            if(s[0] == _childlabel) { Add() }

            if(s[0] != _childlabel) { }


        }

        public bool Contains(string str)
        {
            if (str == "") 
            {
                return _emptystr;
            }
            else if(str[0] == _childlabel)
            {
                return _onlychild.Contains(str.Substring(0, 1);
            }
            return false;
        }
    }
}
