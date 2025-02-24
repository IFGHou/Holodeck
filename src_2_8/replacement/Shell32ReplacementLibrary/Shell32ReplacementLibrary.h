//*************************************************************************
// Copyright (C) Security Innovation, LLC, 2002-2004  All Rights Reserved.
//
// FILE:		Shell32ReplacementLibrary.h
//
// DESCRIPTION: Contains replacement library prototypes for shell32.dll
//
//=========================================================================
// Modification History
//
// Generated 04/07/2004 06:55:05 PM
//*************************************************************************
#pragma once

#define _WIN32_WINNT 0x0501

#include <windows.h>
#include "Registry.h"
#include "ReplacementLibrary.h"
#include "Log.h"

using namespace Replacement;
using namespace Log;

// function pointer definitions
typedef WINSHELLAPI HINSTANCE (STDAPICALLTYPE *ShellExecuteAFunction)(HWND, LPCSTR, LPCSTR, LPCSTR, LPCSTR, int);
typedef WINSHELLAPI HINSTANCE (STDAPICALLTYPE *ShellExecuteWFunction)(HWND, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, int);

// original function pointers
ShellExecuteAFunction realShellExecuteA = NULL;
ShellExecuteWFunction realShellExecuteW = NULL;

ReplacementLibrary *library = NULL;
LogSender *logSender = NULL;
