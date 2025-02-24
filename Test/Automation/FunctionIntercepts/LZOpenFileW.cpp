#include "common.h"


BOOL My_LZOpenFileW()
{
	LPWSTR lpFileName=NULL;
	LPOFSTRUCT lpReOpenBuf=NULL;
	WORD wStyle=NULL;
	INT returnVal_Real = NULL;
	INT returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	__try{
	disableInterception();
	returnVal_Real = LZOpenFileW (lpFileName,lpReOpenBuf,wStyle);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = LZOpenFileW (lpFileName,lpReOpenBuf,wStyle);
	error_Intercepted = GetLastError();
	}__except(puts("in filter"), 1){puts("exception caught");}
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}
