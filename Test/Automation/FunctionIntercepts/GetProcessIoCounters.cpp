#include "common.h"


BOOL My_GetProcessIoCounters()
{
	HANDLE hProcess=NULL;
	PIO_COUNTERS lpIoCounters=NULL;
	BOOL returnVal_Real = NULL;
	BOOL returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	__try{
	disableInterception();
	returnVal_Real = GetProcessIoCounters (hProcess,lpIoCounters);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = GetProcessIoCounters (hProcess,lpIoCounters);
	error_Intercepted = GetLastError();
	}__except(puts("in filter"), 1){puts("exception caught");}
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}
