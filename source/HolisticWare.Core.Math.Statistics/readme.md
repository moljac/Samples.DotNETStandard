# Math.Statistics utilities

Code based on:

    *   https://code.msdn.microsoft.com/Basic-C-Statistics-Library-26ac5403/sourcecode?fileId=145263&pathId=196059644

Modifications:

    *   algorithms as IEnumerable<T> extensions
    *   tuples

TODOs:

    *   optimizations and code reduction based on specific type used
    *   aync/await
    *   


## Integer Data Types

|---------|-------------------------|------------------|-----------------|------|
| Type    | Description             | Minimum          | Maximum         | Bits |
|---------|-------------------------|------------------|-----------------|------|
| bool    | Boolean flag            | false            | true            | 1    |
| byte    | Unsigned Byte           | 0                | 255             | 8    |
| sbyte   | Signed Byte             | -128             | 127             | 8    |
| short   | Signed Short Integer    | -32,768          | 32,767          | 16   |
| ushort  | Unsigned Short Integer  | 0                | 65,535          | 16   |
| int     | Signed Integer          | -2,147,483,648   | 2,147,483,647   | 32   |
| uint    | Unsigned Integer        | 0                | 4,294,967,295   | 32   |
| long    | Signed Long Integer     | -9x1018          | 9x1018          | 64   |
| ulong   | Unsigned Long Integer   | 0                | 1.8x1019        | 64   |
|---------|-------------------------|------------------|-----------------|------|



## Non-Integer (Floating Point) Data Types

|---------|-------------------------|-------------------------|-----------------|------|
| Type    | Description             | Scale                   | Precision       | Bits |
|---------|-------------------------|-------------------------|-----------------|------|
| float   | Single Precision Number | ±1.5x10-45 to ±3.4x1038 | 7 digits        | 32   |
| double  | Double Precision Number | ±5x10-324 to ±1.7x10308 | 15 or 16 digits | 64   |
| decimal | Decimal Number          | ±10-28 to ±7.9x1028     | 28 or 29 digits | 128  |
|---------|-------------------------|-------------------------|-----------------|------|
    




 ## Numeric Data Types

    byte
    sbyte
    short
    ushort
    int
    unit
    long
    ulong
    float
    double
    decimal
