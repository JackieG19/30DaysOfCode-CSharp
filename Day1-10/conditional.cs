using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {
  /*
   if odd# (1,3,5,7,9,11,13,15,17,19) = Weird
   if even# / range of 2-5(2,4) = Not Weird
   if even# / range of 6-20(6,8,10,12,14,16,18,20) = Weird
   if even# / greater than 20 = Not Weird
   */

    static void Main(string[] args) {
    
        int N = Convert.ToInt32(Console.ReadLine());
        
        if (N % 2 == 0) // if even
        {
            Console.Write("Not Weird");
        }
        else // else odd
        {
            Console.Write("Weird");
        }
    }
}
