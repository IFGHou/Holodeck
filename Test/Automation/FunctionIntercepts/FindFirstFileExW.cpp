#include "common.h"


BOOL My_FindFirstFileExW()
{
	LPCWSTR lpFileName=NULL;
	FINDEX_INFO_LEVELS fInfoLevelId;
	LPVOID lpFindFileData=NULL;
	FINDEX_SEARCH_OPS fSearchOp;
	LPVOID lpSearchFilter=NULL;
	DWORD dwAdditionalFlags=NULL;
	HANDLE returnVal_Real = NULL;
	HANDLE returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	__try{
	disableInterception();
	returnVal_Real = FindFirstFileExW (lpFileName,fInfoLevelId,lpFindFileData,fSearchOp,lpSearchFilter,dwAdditionalFlags);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = FindFirstFileExW (lpFileName,fInfoLevelId,lpFindFileData,fSearchOp,lpSearchFilter,dwAdditionalFlags);
	error_Intercepted = GetLastError();
	}__except(puts("in filter"), 1){puts("exception caught");}
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}
