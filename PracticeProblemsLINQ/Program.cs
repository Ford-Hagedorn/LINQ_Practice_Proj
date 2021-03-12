using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            List<string> words = new List<string>();
            words.Add("the");
            words.Add("bike");
            words.Add("this");
            words.Add("it");
            words.Add("tenth");
            words.Add("mathematics");


            //Problem 2
            List<string> names = new List<string>();
            names.Add("Mike");
            names.Add("Brad");
            names.Add("Nevin");
            names.Add("Ian");
            names.Add("Mike"); 


            //Problem 3 & Problem 4
            List<Customer> customers = new List<Customer>();

            new Customer(1, "Mike", "Rodgers");
            new Customer(2, "Nick", "Allen");
            new Customer(3, "Jason", "Ryan");
            new Customer(4, "Dan", "Laffey");
            


            //Problem 5
            List<string> classGrades = new List<string>();


            classGrades.Add("80,100,92,89,65");
            classGrades.Add("93,81,78,84,69");
            classGrades.Add("73,88,83,99,64");
            classGrades.Add("98,100,66,74,55");
            


            //--------------------
            //Bonus Problem 1
            //string letters = "terrill";

            LinqProblems.RunProblem1(words);
            LinqProblems.RunProblem2(names);
            LinqProblems.RunProblem3(customers);
            LinqProblems.RunProblem4(customers);
            LinqProblems.RunProblem5(classGrades);
            Console.ReadLine();


        }
    }
}
