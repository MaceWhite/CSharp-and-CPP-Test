#ifndef CPP_TEST_H
#define CPP_TEST_H

#define DLL_EXPORT __declspec(dllexport) // This exposes created APIs for external use in a DLL file, this is only for Windows, if you're using *nix (MacOS, Linux, FreeBSD, etc) you don't need this

extern "C"
{
   DLL_EXPORT int GenNumberOneToFive();
}

#endif // CPP_TEST_H
