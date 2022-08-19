# RegReader
## Description
This project was primarily made just so I could view the value of a Registry key without having to retype the string representation in RegEdit into Notepad++, but I guess it could be useful for other things. It can view strings, dwords, qwords, and binary.

## How To Use
To read a Registry key, specify the path to it, then the name of the key itself, then the name of the value you want to read.

Otherwise:<br/>
  - `Path`: The path to the Registry key, but don't include the actual name of the key you're reading in this.<br/>
  - `Key`: The key you want to read.<br/>
  - `Value`: The value you want to read from the key you specified.<br/>
  - `Read Key (Button)`: Uses [Microsoft.Win32.Registry]() to read the key specified.
    - The different Registry values are ***STRING***, ***BINARY***, ***DWORD***, and ***QWORD***.
    - Each value type is tested against the type retrieved from the Registry value read using `keyValue.GetType()`.
    - If it's a ***STRING***, the value itself isn't processed.
      - e.g. `The quick brown fox jumps over the lazy dog.`
    - If it's a ***BINARY***, the value is returned as a `byte[]` and converted to a string of characters.
      - e.g. `48 65 6C 6C 6F 20 57 6F 72 6C 64 21` - translates to `Hello World!`
    - If it's a ***DWORD***, the value is just a number displayed as a string
      - e.g. if `0x0000005`, then it's displayed as `5`
    - If it's a ***QWORD***, the same thing as ***DWORD*** but with an `L` at the end to display a difference in the value type.
      - e.g. if `0x0000005`, then it's displayed as `5L`

## Download
[Standalone](https://github.com/Lexz-08/RegReader/releases/latest/download/RegReader.zip)
