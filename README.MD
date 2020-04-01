Unquoted Service Path Vulnerability Scanner and Patcher
====================================

Sometimes it is possible to escalate privileges by abusing misconfigured services. 
Specifically, this is possible if path to the service binary is not wrapped in quotes and there are spaces in the path.
This stems from the way Windows handles CreateProcess API calls:
```
BOOL CreateProcessA(
  LPCSTR                lpApplicationName,
  LPSTR                 lpCommandLine,
  LPSECURITY_ATTRIBUTES lpProcessAttributes,
  LPSECURITY_ATTRIBUTES lpThreadAttributes,
  BOOL                  bInheritHandles,
  DWORD                 dwCreationFlags,
  LPVOID                lpEnvironment,
  LPCSTR                lpCurrentDirectory,
  LPSTARTUPINFOA        lpStartupInfo,
  LPPROCESS_INFORMATION lpProcessInformation
);
```
If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin; otherwise, the file name is ambiguous. For example, consider the string "c:\program files\sub dir\program name". This string can be interpreted in a number of ways. The system tries to interpret the possibilities in the following order:
```
c:\program.exe
c:\program files\sub.exe 
c:\program files\sub dir\program.exe
c:\program files\sub dir\program name.exe...
```
for more details see:

https://docs.microsoft.com/en-us/windows/desktop/api/processthreadsapi/nf-processthreadsapi-createprocessa

With this program you can enumerate and patch "nquoted Service Path" vulnerability in your system and Create **POC** For Them. 

![Image of Yaktocat](https://github.com/l4tr0d3ctism/USPScanner/blob/master/USP%20SCANNER/bin/Release/program.jpg)

Need File: .NET Framwork 3.5

download link: https://github.com/l4tr0d3ctism/USPScanner/blob/master/USP%20SCANNER/bin/Release/USP%20SCANNER.exe
