using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyMiniProject
{
    internal class AppMain
    {
        static void Main(string[] args)
        {
            InterfaceImplementation interfaceImplementation = new InterfaceImplementation();
            interfaceImplementation.showFirstScreen();

            Console.ReadLine();
        }
    }
}