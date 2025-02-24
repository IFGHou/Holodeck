#include "common.h"


BOOL My_GetSystemTimeAsFileTime()
{
	LPFILETIME lpSystemTimeAsFileTime=NULL;
	
	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	disableInterception();
	GetSystemTimeAsFileTime (lpSystemTimeAsFileTime);
	error_Real = GetLastError();
	enableInterception();
	GetSystemTimeAsFileTime (lpSystemTimeAsFileTime);
	error_Intercepted = GetLastError();
	return (error_Real == error_Intercepted);
}
