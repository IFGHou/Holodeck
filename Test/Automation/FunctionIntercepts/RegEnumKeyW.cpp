#include "common.h"


BOOL My_RegEnumKeyW()
{
	HKEY hKey=NULL;
	DWORD dwIndex=NULL;
	LPWSTR lpName=NULL;
	DWORD cbName=NULL;
	LONG returnVal_Real = NULL;
	LONG returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	__try{
	disableInterception();
	returnVal_Real = RegEnumKeyW (hKey,dwIndex,lpName,cbName);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = RegEnumKeyW (hKey,dwIndex,lpName,cbName);
	error_Intercepted = GetLastError();
	}__except(puts("in filter"), 1){puts("exception caught");}
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}
