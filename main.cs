using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.InteropServices;
using Internal;

namespace Internal
{
   public class CPP_Script
   {
      [DllImport("CPP_Test"), EntryPoint("GenNumberOneToFive")] // This line is needed to be able to call the C++ funtion. We can add ".dll" and the end of CPP_Test, but it's not strictly necessary. We can also leave out EntryPoint if we want, but I'll use it for readability.

      private static extern int GenNumberOneToFive(); // This is the C++ function we want to call

      public void Start()
      {
         int randomNumber = GenNumberOneToFive();
         Console.Write(randomNumber);
      }
   };
}

namespace Main
{
   class Program
   {
      public static void Main(string[] args)
      {
         CPP_Script script = new CPP_Script();
         script.Start();
      }
   }
}

