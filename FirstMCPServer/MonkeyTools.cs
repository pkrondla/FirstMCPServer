using System;
using System.ComponentModel;
using System.Text.Json;
using ModelContextProtocol.Server;

namespace FirstMCPServer;

[McpServerToolType]
public class MonkeyTools
{
    [McpServerTool, Description("Get a list of monkeys")]
    public static async Task<string> GetMonkeys(MonkeyService monkeyService)
    {
        var monkeys = await monkeyService.GetMonkeys();
        return JsonSerializer.Serialize(monkeys);
    }
    [McpServerTool, Description("Get a specific monkey by name")]
    public static async Task<string?> GetMonkeyByName(MonkeyService monkeyService, string name)
    {
        var monkey = await monkeyService.GetMonkey(name);
        return monkey == null ? null : JsonSerializer.Serialize(monkey);
    }

    [McpServerTool, Description("Draw a bar graph of monkey populations")]
    public static async Task<string> DrawMonkeyGraph(MonkeyService monkeyService)
    {
        var monkeys = await monkeyService.GetMonkeys();
        var maxPopulation = monkeys.Max(m => m.Population);
        var scale = 50.0 / maxPopulation; // Scale to max width of 50 characters
        var sb = new System.Text.StringBuilder();
        
        sb.AppendLine("Monkey Population Distribution:");
        sb.AppendLine("--------------------------------");
        
        foreach (var monkey in monkeys.OrderByDescending(m => m.Population))
        {
            var barLength = (int)(monkey.Population * scale);
            var bar = new string('█', barLength);
            sb.AppendLine($"{monkey.Name,-20} {monkey.Population,7} {bar}");
        }
        
        return sb.ToString();
    }

    [McpServerTool, Description("Test if the MCP server is working")]
    public static string TestTool()
    {
        return "MCP Server is working!";
    }
}
