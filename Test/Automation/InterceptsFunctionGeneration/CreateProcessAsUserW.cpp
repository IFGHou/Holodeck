#include "common.h"


BOOL My_CreateProcessAsUserW()
{
	HANDLE hToken=NULL;
	LPCWSTR lpApplicationName=NULL;
	LPWSTR lpCommandLine=NULL;
	LPSECURITY_ATTRIBUTES lpProcessAttributes=NULL;
	LPSECURITY_ATTRIBUTES lpThreadAttributes=NULL;
	BOOL bInheritHandles=NULL;
	DWORD dwCreationFlags=NULL;
	LPVOID lpEnvironment=NULL;
	LPCWSTR lpCurrentDirectory=NULL;
	LPSTARTUPINFOW lpStartupInfo=NULL;
	LPPROCESS_INFORMATION lpProcessInformation=NULL;
	BOOL returnVal_Real = NULL;
	BOOL returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	disableInterception();
	returnVal_Real = CreateProcessAsUserW (hToken,lpApplicationName,lpCommandLine,lpProcessAttributes,lpThreadAttributes,bInheritHandles,dwCreationFlags,lpEnvironment,lpCurrentDirectory,lpStartupInfo,lpProcessInformation);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = CreateProcessAsUserW (hToken,lpApplicationName,lpCommandLine,lpProcessAttributes,lpThreadAttributes,bInheritHandles,dwCreationFlags,lpEnvironment,lpCurrentDirectory,lpStartupInfo,lpProcessInformation);
	error_Intercepted = GetLastError();
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}
