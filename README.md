# King's Bounty Prototype (Console)

<img alt="logo" src="https://www.objectionary.com/cactus.svg" height="100px" />  

[![EO principles respected here](https://www.elegantobjects.org/badge.svg)](https://www.elegantobjects.org)
[![We recommend IntelliJ Rider](https://www.elegantobjects.org/intellij-idea.svg)](https://www.jetbrains.com/rider/)  

[![.NET](https://img.shields.io/badge/.NET-9.0-512BD4&logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-239120?style&logo=csharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![GitHub Last Commit](https://img.shields.io/github/last-commit/LLarean/kings-bounty-console)](https://github.com/llarean/kings-bounty-console/graphs/commit-activity)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/llarean/kings-bounty-console/blob/main/LICENSE)
[![CodeFactor](https://www.codefactor.io/repository/github/llarean/kings-bounty-console/badge)](https://www.codefactor.io/repository/github/llarean/kings-bounty-console)
[![Inspiration](https://img.shields.io/badge/Inspiration-King's%20Bounty-%23blueviolet)](https://en.wikipedia.org/wiki/King%27s_Bounty)

A simple prototype of a game inspired by the classic King's Bounty (1990) game with basic logic and console display. This project serves as a playground for practicing Object-Oriented Programming principles and Elegant Objects design patterns in C#.

![World Map](https://github.com/LLarean/kings-bounty-console/blob/main/Screenshots/WorldMap.png)

## Game Controls

### Hotkeys
- **ESC** - Go back / Exit menu
- **Arrow Keys** - Move hero on the map
- **Enter** - Confirm selection / Interact

### Map Symbols
The game world is represented using ASCII characters:

| Symbol | Meaning |
|--------|---------|
| `g` | Ground |
| `w` | Water |
| `s` | Sand |
| `m` | Mountain |
|--------|---------|
| `H` | Hero (your character) |
| `C` | Castle |
| `E` | Enemy |
| `T` | Treasure |

## Learning Goals

This project focuses on exploring and implementing:
- **Elegant Objects** principles by Yegor Bugayenko
- Clean OOP design without getters/setters
- Immutable objects and functional approach
- SOLID principles in practice
- Domain-driven design patterns

## Quick Start

### Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
- Any IDE supporting C# (recommended: [JetBrains Rider](https://www.jetbrains.com/rider/))

### Installation & Running
```bash
git clone https://github.com/LLarean/kings-bounty-console.git
cd kings-bounty-console
dotnet restore
dotnet run
```

## Architecture & Design Patterns

### Key Design Decisions
- **No public getters/setters** - following Elegant Objects principles
- **Immutable objects** - state changes create new instances
- **Small interfaces** - single responsibility principle
- **Composition over inheritance** - flexible object relationships

### Project Structure

```
```

## Code Style

This project follows [Elegant Objects](https://www.elegantobjects.org/) principles:
- Objects are never mutable
- No static methods (except entry points)
- No NULL references
- No code in constructors
- Maximum 4 public methods per class

## Testing

## Code Quality

## Learning Resources

Resources that influenced this project:
- [Elegant Objects](https://www.elegantobjects.org/) by Yegor Bugayenko
- [Clean Code](https://www.amazon.com/Clean-Code-Handbook-Software-Craftsmanship/dp/0132350882) by Robert Martin
- [Domain-Driven Design](https://www.amazon.com/Domain-Driven-Design-Tackling-Complexity-Software/dp/0321125215) by Eric Evans

## License

This project is licensed under the MIT License - see the [LICENSE.md](https://github.com/LLarean/kings-bounty-console/blob/main/LICENSE) file for details.

## Acknowledgments

- Inspired by the original **King's Bounty** by Jon Van Caneghem & New World Computing
- **Yegor Bugayenko** for Elegant Objects methodology
- The C# and .NET community for excellent tooling and resources

---

*This project is a work in progress and serves as a practical exploration of OOP principles. Code quality and design elegance are prioritized over feature completeness.*
