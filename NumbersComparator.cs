﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ConsoleApp1
{
    class NumbersComparator : IComparer<uint>
    {
        public int Compare(uint x, uint y)
        {
            string strx = x.ToString();
            string stry = y.ToString();

            int shorter = (strx.Length < stry.Length) ? strx.Length : stry.Length;

            for (int i = 0; i < shorter; i++)
            {
                if (strx[i].CompareTo(stry[i]) != 0)
                    return strx[i].CompareTo(stry[i]);
            }
            return 0;
        }       
    }
}
