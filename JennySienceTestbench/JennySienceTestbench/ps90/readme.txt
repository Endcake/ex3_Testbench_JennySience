Content of a directory:

- readme.txt this file
- liesmich.txt german version of this file
- PS90FUNC.cs implementation of the class CPS90Win for linking of the PS90-DLL (e.g., VisualStudio 2010 / VisualC# Professional Edition / Console application)
- PS90TOOL.cs source file for demo program
..\SDK\exe\x86 - demo program (32 bit), 2 batch files
- PS90.dll PS90-function library (version 1.0.9.1, 32 bit)
..\SDK\exe\x64 - demo program (64 bit), 2 batch files
- PS90.dll PS90-function library (version 1.0.9.1, 64 bit)

To use the functions in your application, make the following:
1. Add the file "ps90func.cs" to the project.
2. Add the library "ps90.dll" to the project as file.
Please note, it is the C library, but not the C# assembly.
3. Change project options (tab "Compiling", activate option "Allow unsafe code").
4. Link the namespace "ps90func" ("using ps90func;").

To use the demo application (64 bit), the following files are required:
- Visual C++ Runtime files
These files can be run as prerequisites during installation on a computer that does not have Visual C++ 2010 Express Edition (or higher) installed.
vcredist_x64.exe - Redistributable Package for Visual C++ (64 bit) 
