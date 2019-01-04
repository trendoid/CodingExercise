# Coding Exercise
##### this should take no more than 15-20 minutes.
    
### Here is the exercise:

Write a ‘Hello World’ program.

- The program has 1 current business requirement
    - write “Hello World” to the console/screen. 

- The program should have an API that is separated from the program logic to eventually support mobile applications, web applications, or console applications, or windows services. 

- The program should support future enhancements for writing to a database, console application, etc.
    - Use common design patterns (inheritance, e.g.) to account for these future concerns. 
    - Use configuration files or another industry-standard mechanism for determining where to write the information to. 

Write unit tests to support the API.

---

Here are the commands to I used for a new .NET Core Solution to fullfill the excercise.

```
dotnet new sln --name CodingExcercise
dotnet new console --name Project --output Project
dotnet new classlib --name API --output API
dotnet new mstest --name Tests --output Tests
dotnet sln add .\Project\Project.csproj
dotnet sln add .\API\API.csproj
dotnet sln add .\Tests\Tests.csproj
dotnet restore
dotnet build CodingExcercise.sln
```

    