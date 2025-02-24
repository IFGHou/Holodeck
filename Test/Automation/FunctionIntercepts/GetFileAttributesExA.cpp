#include "common.h"


BOOL My_GetFileAttributesExA()
{
	LPCSTR lpFileName=NULL;
	GET_FILEEX_INFO_LEVELS fInfoLevelId;
	LPVOID lpFileInformation=NULL;
	BOOL returnVal_Real = NULL;
	BOOL returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	__try{
	disableInterception();
	returnVal_Real = GetFileAttributesExA (lpFileName,fInfoLevelId,lpFileInformation);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = GetFileAttributesExA (lpFileName,fInfoLevelId,lpFileInformation);
	error_Intercepted = GetLastError();
	}__except(puts("in filter"), 1){puts("exception caught");}
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}
