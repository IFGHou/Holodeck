#include "common.h"


BOOL My_RegReplaceKeyA()
{
	HKEY hKey=NULL;
	LPCSTR lpSubKey=NULL;
	LPCSTR lpNewFile=NULL;
	LPCSTR lpOldFile=NULL;
	LONG returnVal_Real = NULL;
	LONG returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	__try{
	disableInterception();
	returnVal_Real = RegReplaceKeyA (hKey,lpSubKey,lpNewFile,lpOldFile);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = RegReplaceKeyA (hKey,lpSubKey,lpNewFile,lpOldFile);
	error_Intercepted = GetLastError();
	}__except(puts("in filter"), 1){puts("exception caught");}
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}
