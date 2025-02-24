#include "common.h"


BOOL My_FreeLibraryAndExitThread()
{
	HMODULE hLibModule=NULL;
	DWORD dwExitCode=NULL;
	
	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	__try{
	disableInterception();
	FreeLibraryAndExitThread (hLibModule,dwExitCode);
	error_Real = GetLastError();
	enableInterception();
	FreeLibraryAndExitThread (hLibModule,dwExitCode);
	error_Intercepted = GetLastError();
	}__except(puts("in filter"), 1){puts("exception caught");}
	return (error_Real == error_Intercepted);
}
