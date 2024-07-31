#include <iostream>
#include "CPP_Test.hpp"

/*
   We compile this file into a .dll or .so file. We only compile this file, not the header file.
*/

extern "C" // We say extern "C" to tell the compiler that this isn't C++ code
{
   DLL_EXPORT int GenNumberOneToFive() // The actual function
   {
      int result = rand()% 5 + 1; // Plus 1 since it starts at 0
      return result;
   }
}
