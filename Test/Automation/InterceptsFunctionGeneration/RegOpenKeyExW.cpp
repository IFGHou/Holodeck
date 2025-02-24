#include "common.h"


BOOL My_RegOpenKeyExW()
{
	HKEY hKey=NULL;
	LPCWSTR lpSubKey=NULL;
	DWORD ulOptions=NULL;
	REGSAM samDesired=NULL;
	PHKEY phkResult=NULL;
	LONG returnVal_Real = NULL;
	LONG returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	disableInterception();
	returnVal_Real = RegOpenKeyExW (hKey,lpSubKey,ulOptions,samDesired,phkResult);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = RegOpenKeyExW (hKey,lpSubKey,ulOptions,samDesired,phkResult);
	error_Intercepted = GetLastError();
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}
