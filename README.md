How to get Sublime Text 2 working with GCC
==========================================

Usage:
------

It's very simple: use **Control + b** when in Sublime Text 2 to compile and run your C file.

If there are errors compiling, these will show in the Sublime console window. If there are errors compiling, the file that is run may either not exist or be out of date (the .exe is not updated when there is compiler errors), so always check the console!

When your compiled file is run, this runs in a separate cmd.exe window to show output. [More details below under alternate options]

Installation Instructions
--------------------------

**Download all the files in the repository first using git clone / or the download as a .zip option. Don't try and copy the text across!**

(sublime text is the best and you should all use it unless you're a vim fag or something idk)

(if you're using a mac this is a billion times easier, just point Sublime at GCC with the appropriate flags; have fun)

First, go install MinGW - this is a port of GCC (Gnu C Compiler) to Windows. You can find the installer [here](http://sourceforge.net/projects/mingw/files/latest/download?source=files).

Use all the default options.

Once it's installed, you need to add GCC to your path variable. To do this, right click on My Computer, go to Properties -> Advanced System Settings -> Environment Variables

If you're daft enough to use [UAC](http://en.wikipedia.org/wiki/User_Account_Control) make sure to give it admin privileges when it asks.

Under the "System variables" box, find "PATH" and click edit. It should have a bunch of stuff in already, for example: http://i.imgur.com/XrZ3Q.png.

Append ";C:\MinGW\bin" to that: [image](http://i.imgur.com/QXVc8.png) [if you installed it in a different location, edit this as appropriate]

Click OK on all the windows, and test that it works by bringing up a command prompt and typing gcc. If it works, you should get something like this: http://i.imgur.com/DZoZO.png

If you got a "'gcc' is not recognized as an internal or external command, operable program or batch file.", then you fucked something up; go check everything then restart and try again.

Next, install [Sublime Text 2](http://www.sublimetext.com/2). Pro tip: add the right click menu thing, so you can easily open up anything in Sublime.

Download compile.bat, and save it in the main folder where you keep your code (e.g. D:\Coding\ or whatever) (I think there was a reason for not having it in the same folder as GCC, but I've forgotten. WONTFIXWORKS4ME)

Then, go to "%appdata%\Sublime Text 2\Packages\User" and paste in C.sublime-build. Open it up (in Sublime!), and make sure the D:/Coding/Compile.bat is changed to wherever you saved it in the previous step.

This should be all done - close down all Sublime Text windows and all command prompts (to make sure they get the updated path variable); then test it out by re-opening Sublime Text, and compiling a file. If it works, you should get something like [this](http://i.imgur.com/00Zyd.png).

If it doesn't work, restart your computer or something.

Alternate option: (Don't like having console windows everywhere?)
---------------------------------------------

Use C_alternate.sublime-build. Rename it to C.sublime-build when you copy it over to your %appdata%\Sublime Text 2\Packages\User directory.

This has the upside of not spamming console windows (which can be annoying if you're compiling and have errors), but has the downside of not executing the file (so you'll have to open up a command prompt window, navigate to your coding folder, and run the exe from within that every time you want to run your file)

Known Issues:
-------------

- when compiling example.c, you get example.c.exe instead of just example.exe. I tried fixing this with regex but it didn't work and I gave up; if someone can figure it out, let me know and I'll update this (or submit a git pull thing!)

- alternate version doesn't execute files after compiling. Would be nice if it could execute on a successful build; suggestions welcome!