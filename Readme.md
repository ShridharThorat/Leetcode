## 1. Creating a new leetcode problem folder
1. Create a new folder with the name `X - Name` replace Name with the name of the problme
2. Add a `description.md` that describes what the function does
3. Add a new project with a name; lets refer to it as `SolutionX`. You can do this by either 
a. `cd X\ -\ Name/; dotnet new console -n SolutionX` 
b. Right click on the solution Leetcode and add a new project inside the folder `X - Name`
4. Right click on the `Master_test` Project and add `SolutionX` as a new reference (i.e. dependency)

## 2. Running

### 2.1 A simple way
1. Build  `SolutionX`
2. Right click and select `Open in Integrated terminal`
3. Type `dotnet run` to run it


### 3.1 Another way
This doesn't have as clean a layout as the above option but it's faster -> jyst click run on the `Run and Debug tab`
1. Modify the `launch.json` so the `program` matches below.
```json
{
    "program": "${workspaceFolder}/X - Name/SolutionX/bin/Debug/net7.0/SolutionX.dll",
}
```



### Starting Class
```cs
namespace Solution; // Stays the same for all projects
public class SolutionX {

    public static string SolutionName()
    {
        return "Example X";
    }
    public static void Main()
    {
        Console.WriteLine(SolutionName());
    }
}
```