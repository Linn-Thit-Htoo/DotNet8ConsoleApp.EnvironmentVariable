namespace DotNet8ConsoleApp.EnvironmentVariable;

public class Program
{
    public static void Main(string[] args)
    {
        var path =
            @"C:\projects\Examples\DotNet8ConsoleApp.EnvironmentVariable\DotNet8ConsoleApp.EnvironmentVariable\.env";
        DotNetEnv.Env.Load(path);

        var message = Environment.GetEnvironmentVariable("MESSAGE");
        Console.WriteLine($"MESSAGE: {message}");
    }
}
