using System;
using System.Collections.Generic;
using System.IO;

class Person {
    public int age;     
	public Person(int initialAge) {
        // Add some more code to run some checks on initialAge
        // If age < 13, print You are young.
        // If  and age > 13, age < 18, print You are a teenager.
        // Else, print You are old.
     }
     public void amIOld() {
        // Do some computations in here and print out the correct statement to the console 
        Console.WriteLine("Age is not valid, setting age to 0..");
        Console.WriteLine("You are young.");
        Console.WriteLine("You are teenager.");
        Console.WriteLine("You are old.");
     }

     public void yearPasses() {
        // Increment the age of the person in here
     }

static void Main(String[] args) {
        int T=int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) {
            int age=int.Parse(Console.In.ReadLine());
            Person p=new Person(age);
             p.amIOld();
                for (int j = 0; j < 3; j++) {
                  p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
        }
    }
}
