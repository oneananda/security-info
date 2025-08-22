using System;
using System.Net.Http;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string url = "https://raw.githubusercontent.com/someuser/unverified-repo/main/payload.csx";
        string filePath = "payload.csx";

        Console.WriteLine("Downloading script from untrusted source...");
        using var client = new HttpClient();
        var script = await client.GetStringAsync(url);
        await File.WriteAllTextAsync(filePath, script);

        Console.WriteLine("Executing downloaded script...");
        Process.Start("dotnet-script", filePath); // ⚠️ Dangerous: executes unverified code
    }
}
