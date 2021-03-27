Create directory hierarchy from information contained in a text file.

so imagine you file contains:
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

you can run this app and pass the txt file, it will end up creating the following directory sturcture:
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

and thats it!

