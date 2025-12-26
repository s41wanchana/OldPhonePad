# OldPhonePad – C# Coding Challenge

## Overview
This project implements a solution to the Old Phone Pad problem using C# and .NET.  
The core logic is separated from the application entry point to keep the solution testable, readable, and easy to extend.

## Project Structure
- `OldPhonePad` – Core domain logic (pure, testable code)
- `OldPhonePad.App` – Console application entry point
- `OldPhonePad.Tests` – Unit tests for core logic
- `AI-PROMPT.md` – AI usage disclosure

## Design Decisions

The original problem statement does not specify behavior for inputs with more than the allowed number of consecutive identical digit presses. In this implementation, consecutive presses are capped at three per character, except for digits 7 and 9, which allow up to four presses. Additional presses are treated as the start of a new character. This choice keeps the behavior predictable and aligns with the typical old phone keypad model.

## Edge Cases Handled
- Empty input
- Leading or consecutive backspace characters (`*`)
- Backspace operations on an empty state

## How to Run
From the project root:

````bash
dotnet build
dotnet run --project src/OldPhonePad.App -- "<input>"

## Test
dotnet test tests/OldPhonePad.Tests/OldPhonePad.Tests.csproj
