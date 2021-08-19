# aoc_bug_2020_06
The F# solution with the test that caused a dotnet error on Mac. Running it produces the correct result.

`dotnet test` causes system to crash (at least on my machine). Also, chopping the input size does not crash it anymore (Though test fails because it ain't the desired output)
