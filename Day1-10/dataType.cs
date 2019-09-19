using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Console.WriteLine(i);
        // Console.WriteLine(d);
        // Console.WriteLine(s);
        
        // Declare second integer, double, and String variables.
        int e;
        double f;
        string t; 
        
        // Read and save an integer, double, and String to your variables.
        e = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(e); // 12

        f = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine(f); // 4 

        t = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + e);

        // Print the sum of the double variables on a new line.
        Console.WriteLine("{0:0.0}", d + f);

        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + t);
    }
}
