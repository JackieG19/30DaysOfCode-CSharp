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
    static void solve(double meal_cost, int tip_percent, int tax_percent) {
        
       //  meal cost = 12.00, tip percent = 20, tax percent = 8
       
       var tip = tip_percent * meal_cost / 100;
        //Console.WriteLine(tip); // 2.4

        var tax = tax_percent * meal_cost/ 100;
        //Console.WriteLine(tax); // 0.96

        var totalCost = Math.Round(tax + tip + meal_cost);
        Console.WriteLine(totalCost); // 15
    }

    static void Main(string[] args) {
        double meal_cost = Convert.ToDouble(Console.ReadLine());
        int tip_percent = Convert.ToInt32(Console.ReadLine());
        int tax_percent = Convert.ToInt32(Console.ReadLine());
        solve(meal_cost, tip_percent, tax_percent);
    }
}
