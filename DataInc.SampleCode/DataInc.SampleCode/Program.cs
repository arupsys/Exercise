using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataInc.ExtensionsLib;

namespace DataInc.SampleCode
{
    class Program
    {
        //"This is a statement, and so is this"
        //Output is in descending order. 
        //Should return the distinct list of words with a count of their usage
        //this - 2
        //is – 2
        // a – 1
        //statement – 1 
        //and – 1
        //so - 1 
        //I have assumed it to be case insensitive comparison
        //I am really tempted to implement this as simple extension method. 
        //Some could heavily dislike such static implementation but I feel
        //word usage within a string should have been provided as a part of the 
        //framework.
        static void Main(string[] args)
        {
            var result = "This is a statement, and so is this".GetWordUsage();
            foreach (var word in result)
                Console.WriteLine(word.ToLower());
            Console.ReadLine();
        }
    }
}
