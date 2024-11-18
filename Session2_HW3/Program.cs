using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;

namespace QATraining2_3

{
    class SubstringToUpper
    {
        static void Main(string[] args)
        {
            string sentenceA = "This sentence is pointless.";
            int charPos = sentenceA.IndexOf("p");
            string wordA = sentenceA.Substring(charPos, 9);

            Console.WriteLine("This was the original sentence:");
            
            Console.WriteLine(sentenceA);
            
            Console.WriteLine("Original substring: " + wordA);
            Console.WriteLine("Modified substring: " + wordA.ToUpper());



        }
    }
}


