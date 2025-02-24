#include "common.h"


BOOL My_FileEncryptionStatusA()
{
	LPCSTR lpFileName=NULL;
	LPDWORD lpStatus=NULL;
	BOOL returnVal_Real = NULL;
	BOOL returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	__try{
	disableInterception();
	returnVal_Real = FileEncryptionStatusA (lpFileName,lpStatus);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = FileEncryptionStatusA (lpFileName,lpStatus);
	error_Intercepted = GetLastError();
	}__except(puts("in filter"), 1){puts("exception caught");}
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}
