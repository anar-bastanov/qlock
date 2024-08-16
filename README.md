# Quine Clock
Qlock is a clock program that outputs its own source code and highlights characters in certain positions to display local time.

![Preview](/res/preview.gif)

NOTE: A [quine](https://en.wikipedia.org/wiki/Quine_%28computing%29) is a computer program that takes no input and produces a copy of its own source code as its only output.

## Installation
The repository contains two Visual Studio projects, and each project has two C# files, one is the quine clock program and the other is the readable version of the same code.
 1. Download the whole repository.
 2. Double-click the solution file (.sln) to open projects in Visual Studio.
 3. Configure the startup project first or press Run right away.

The reason why there are two projects in the first place is that the newest C# versions have an optional feature called [Implicit Using Directives](https://learn.microsoft.com/en-us/dotnet/core/project-sdk/overview#implicit-using-directives), and it allows shortening some code, thus the two versions of the same quine:
| Project | Target Framework | Implicit Usings |
|:--------|:----------------:|:---------------:|
| `quine-clock.csproj`				   | .NET 6 | disabled |
| `quine-clock-implicit-usings.csproj` | .NET 8 | enabled  |

## References
Other implementations:
 * [Original author, written in JavaScript](https://aem1k.com/qlock/)
 * [Tsoding's version, written in C](https://gist.github.com/rexim/f582098611b2be202051ba543e21da05)

## License
Copyright &copy; 2024 Anar Bastanov  
Distributed under the [MIT License](http://www.opensource.org/licenses/mit-license.php).
