#include "common.h"


BOOL My_SetFileSecurityW()
{
	LPCWSTR lpFileName=NULL;
	SECURITY_INFORMATION SecurityInformation=NULL;
	PSECURITY_DESCRIPTOR pSecurityDescriptor=NULL;
	BOOL returnVal_Real = NULL;
	BOOL returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	disableInterception();
	returnVal_Real = SetFileSecurityW (lpFileName,SecurityInformation,pSecurityDescriptor);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = SetFileSecurityW (lpFileName,SecurityInformation,pSecurityDescriptor);
	error_Intercepted = GetLastError();
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}
