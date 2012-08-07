:: usage: compile [outputName]
:: cd "C:/MinGW/bin"  :: uncomment this line if shit doesn't work
:: ^ edit /your/path/here/ to where you're actually storing this
gcc %1 -std=c99 -o %1.exe

:: run program

start c:\windows\system32\cmd.exe /K %1.exe
