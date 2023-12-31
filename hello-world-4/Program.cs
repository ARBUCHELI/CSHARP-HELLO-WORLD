﻿/* In order to run these kinds of programs, go the the folder that contains the program and follow the steps:
    1) type cmd
    2) In cmd type >> dotnet new console
    3) That will generate a Program.cs file.  Edit that file with your code (For now.  In the future we'll find a more efficient
    way to do this.)
    4) In the terminal type dotnet run
*/

using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      /* This program reads input from the user, and 
         assigns it to the input variable.  Then the 
         program print a message that includes the input
         variable.
      */
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      Console.WriteLine($"You are {input} years old!");
    }
  }
}
