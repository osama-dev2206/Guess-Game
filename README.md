# Guess-Game

A simple number guessing game built with **C#** and **Windows Forms**.


<img width="951" height="520" alt="Screenshot 2026-06-22 224600" src="https://github.com/user-attachments/assets/ca666d4a-4127-430f-ad6a-0d4b65abcf1c" />

<img width="973" height="503" alt="Screenshot 2026-06-22 224609" src="https://github.com/user-attachments/assets/0096c967-3d1c-4475-9ab6-c5cde8aed41e" />

<img width="959" height="499" alt="Screenshot 2026-06-22 224620" src="https://github.com/user-attachments/assets/1fcf7f1f-29b4-4103-aa09-a8c2b2c49b9d" />

<img width="958" height="500" alt="Screenshot 2026-06-22 224630" src="https://github.com/user-attachments/assets/d84afa11-b998-402c-bcbf-1834256129c4" />


## Project Idea

The player configures:
- number of rounds
- start of range
- end of range

In each round, the player guesses a number.  
The game compares the guess against a randomly generated number in the selected range and shows whether the guess is correct or wrong.

## Core Components

- `Program.cs`  
  Entry point of the app. Starts the settings form.

- `Core.cs`  
  Shared game logic and state:
  - `stGameInfo` stores game setup (`NumOfRounds`, `StartRange`, `EndRange`)
  - `IsUserInput_InRange(int)` validates whether a number is inside the configured range
  - `CheckUserAnswer(int)` compares user input with a random number and returns win/lose status

- `GameSettings.cs` (`frmGameSettings`)  
  Handles game configuration:
  - sets rounds and range values
  - updates `Core.GameInfo` when controls change
  - starts the main game form

- `GameMainScreen.cs` (`frmGameMainScreen`)  
  Handles gameplay:
  - displays selected settings
  - validates player input
  - checks guess result using `Core.CheckUserAnswer`
  - decrements rounds and ends game when rounds reach zero

## Game Flow

1. App starts on **Settings** screen.
2. Player chooses rounds and number range.
3. Player starts game.
4. For each round:
   - player enters a guess
   - app evaluates guess and shows result
   - remaining rounds decrease
5. When rounds finish, the game closes and returns to settings.

## Technologies

- .NET Framework 4.8.1
- C#
- Windows Forms

## Build Notes

This project targets **.NET Framework 4.8.1**.  
Building on environments without the .NET Framework 4.8.1 targeting pack will fail until the required developer pack is installed.
