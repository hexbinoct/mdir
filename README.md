﻿Create directory hierarchy from information contained in a text file.

**NOTE**: this thing runs on .Net Core, which you can get for your operating system from [here](https://dotnet.microsoft.com/download)

so imagine your file contains (_tabs of space are NOT supported right now, only the tab character \t is supported_):
 ```
one
	two
three
	four
	five
		one
		two
		three
	hello
		sev
		dev
		bin
```
you can run this app and pass the txt file like:
**dotnet mkdir.dll folders.txt**

it will end up creating the following directory sturcture:
```
├── one
│   └── two
└── three
    ├── five
    │   ├── one
    │   ├── three
    │   └── two
    ├── four
    └── hello
        ├── bin
        ├── dev
        └── sev
```
and thats it!

a NOTE:
there is a variable in this source called m_delimpath, it should be set to "\\" for windows and "/" for mac & linux.