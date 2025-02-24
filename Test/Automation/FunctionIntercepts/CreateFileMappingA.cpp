#include "common.h"


BOOL My_CreateFileMappingA()
{
	HANDLE hFile=NULL;
	LPSECURITY_ATTRIBUTES lpFileMappingAttributes=NULL;
	DWORD flProtect=NULL;
	DWORD dwMaximumSizeHigh=NULL;
	DWORD dwMaximumSizeLow=NULL;
	LPCSTR lpName=NULL;
	HANDLE returnVal_Real = NULL;
	HANDLE returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	__try{
	disableInterception();
	returnVal_Real = CreateFileMappingA (hFile,lpFileMappingAttributes,flProtect,dwMaximumSizeHigh,dwMaximumSizeLow,lpName);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = CreateFileMappingA (hFile,lpFileMappingAttributes,flProtect,dwMaximumSizeHigh,dwMaximumSizeLow,lpName);
	error_Intercepted = GetLastError();
	}__except(puts("in filter"), 1){puts("exception caught");}
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}
