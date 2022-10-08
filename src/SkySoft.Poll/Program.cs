namespace SkySoft.Poll;

public class Program
{
    public static void Main(string[] args)
    {
        var app = WebApplication.CreateBuilder(args).Build();

        app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}
