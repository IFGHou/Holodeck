#include "common.h"


BOOL My_VirtualQuery()
{
	LPCVOID lpAddress=NULL;
	PMEMORY_BASIC_INFORMATION lpBuffer=NULL;
	SIZE_T dwLength=NULL;
	SIZE_T returnVal_Real = NULL;
	SIZE_T returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	disableInterception();
	returnVal_Real = VirtualQuery (lpAddress,lpBuffer,dwLength);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = VirtualQuery (lpAddress,lpBuffer,dwLength);
	error_Intercepted = GetLastError();
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}
