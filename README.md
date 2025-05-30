# FirstMCPServer

A C# implementation of a Model Context Protocol (MCP) server for monkey data management and visualization. This project serves as a learning example for building MCP servers and integrating them with AI assistants like Claude.

## 🐒 What is this?

This MCP server provides tools for managing monkey population data, including data retrieval, management, and visualization capabilities. It demonstrates how to build a complete MCP server using C# and integrate it with Claude Desktop for interactive AI-powered data analysis.

## 🌟 Features

- **Monkey Data Management**: Create, retrieve, and manage monkey population data
- **Interactive Tools**: Multiple MCP tools for different monkey-related operations
- **Data Visualization**: Built-in graphing capabilities for population analysis
- **MCP Compliance**: Full adherence to Model Context Protocol standards
- **Claude Integration**: Seamless integration with Claude Desktop

## 🛠️ Project Structure

```
FirstMCPServer/
├── Program.cs              # Main application entry point
├── MonkeyService.cs        # Service implementation for monkey-related operations
├── MonkeyTools.cs          # Utility tools for monkey data processing
└── FirstMCPServer.csproj   # Project configuration file
```

## 📋 Prerequisites

- [.NET 6.0 or later](https://dotnet.microsoft.com/download)
- [Claude Desktop](https://claude.ai/desktop) (for testing MCP integration)
- Basic understanding of C# and .NET development

## 🚀 Quick Start

### 1. Clone the Repository

```bash
git clone https://github.com/pkrondla/FirstMCPServer.git
cd FirstMCPServer
```

### 2. Build the Project

```bash
dotnet build
```

### 3. Run the MCP Server

```bash
dotnet run
```

### 4. Configure Claude Desktop

Add the following configuration to your Claude Desktop MCP settings:

```json
{
    "mcpServers": {
        "mcp-monkey-server": {
            "command": "dotnet",
            "args": [
                "run",
                "--project",
                "C:\\FirstMCPServer\\FirstMCPServer\\FirstMCPServer.csproj",
                "--no-build"
            ]
        }
    }
}
```

## 🔧 Available Tools

The MCP server provides the following tools that can be used through Claude:

### `GetMonkeys`
Retrieves a list of all monkeys in the database.

### `GetMonkeyByName`
Gets detailed information about a specific monkey by name.
- **Parameters**: `name` (string) - The name of the monkey to retrieve

### `DrawMonkeyGraph`
Generates a bar graph visualization of monkey populations.

### `TestTool`
Tests if the MCP server is working correctly.

## 🎯 Usage Examples

Once integrated with Claude Desktop, you can interact with the server using natural language:

```
"Show me all the monkeys in the database"
"Get information about a monkey named 'Bobo'"
"Draw a graph of monkey populations"
"Test if the monkey server is working"
```

## 🏗️ Architecture

### Core Components

- **Program.cs**: Entry point that sets up the MCP server and handles protocol communication
- **MonkeyService.cs**: Business logic for monkey data operations
- **MonkeyTools.cs**: Utility functions for data processing and visualization

### MCP Integration

The server implements the Model Context Protocol by:
1. Exposing tools through the MCP interface
2. Handling tool calls from AI assistants
3. Returning structured responses in MCP format
4. Managing state and context across interactions

## 🧪 Testing

### Manual Testing
1. Start the MCP server
2. Open Claude Desktop with the server configured
3. Try the example commands listed above

### Automated Testing
```bash
dotnet test
```

## 📚 Learning Resources

- [Model Context Protocol Documentation](https://modelcontextprotocol.io/)
- [MCP Specification](https://spec.modelcontextprotocol.io/)
- [Claude Desktop MCP Integration Guide](https://docs.anthropic.com/claude/docs/mcp)

## 🤝 Contributing

This is a learning project, but contributions are welcome! Please feel free to:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 🐛 Issues and Support

If you encounter any issues or have questions:

1. Check the existing [Issues](https://github.com/pkrondla/FirstMCPServer/issues)
2. Create a new issue with detailed information about the problem
3. Include steps to reproduce and expected vs actual behavior

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

## 🙏 Acknowledgments

- [Anthropic](https://www.anthropic.com/) for developing the Model Context Protocol
- The MCP community for documentation and examples
- Contributors and users who help improve this project

## 🔗 Related Projects

- [MCP Official Examples](https://github.com/modelcontextprotocol/examples)
- [Claude Desktop](https://claude.ai/desktop)

---

**Built with ❤️ for learning MCP and sharing knowledge**

*If you find this project helpful, please give it a ⭐ star!*