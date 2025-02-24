#include "common.h"


BOOL My_RegEnumValueA()
{
	HKEY hKey=NULL;
	DWORD dwIndex=NULL;
	LPSTR lpValueName=NULL;
	LPDWORD lpcbValueName=NULL;
	LPDWORD lpReserved=NULL;
	LPDWORD lpType=NULL;
	LPBYTE lpData=NULL;
	LPDWORD lpcbData=NULL;
	LONG returnVal_Real = NULL;
	LONG returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	__try{
	disableInterception();
	returnVal_Real = RegEnumValueA (hKey,dwIndex,lpValueName,lpcbValueName,lpReserved,lpType,lpData,lpcbData);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = RegEnumValueA (hKey,dwIndex,lpValueName,lpcbValueName,lpReserved,lpType,lpData,lpcbData);
	error_Intercepted = GetLastError();
	}__except(puts("in filter"), 1){puts("exception caught");}
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}
