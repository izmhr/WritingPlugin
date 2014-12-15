#include <iostream>

#define DLLExport __declspec (dllexport)

extern "C"
{
	DLLExport int GetRandom()
	{
		return rand();
	}
}
