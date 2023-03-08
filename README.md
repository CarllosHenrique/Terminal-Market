# Compass Market
This program simulates a stock market game, where the player's goal is to double their patrimony.

## How to play
At the beginning of the game, the user is prompted to enter their name.
The user starts with R$500 and can buy shares of 6 different companies.
The user must choose which company to invest in and the quantity of shares to buy.
The price of the shares will be updated with a random variation between -10% and +10%.
The user can sell the shares at any time, but cannot sell more shares than they currently own.
The game ends when the user's balance reaches R$1000.
Code explanation
This program is written in C# and contains a single class named Program. The Main method is the entry point of the application.

The program uses a dictionary to store the companies' names and their stock prices. It also has a variable saldo that represents the user's balance.

Inside a while loop, the program displays the available companies and prompts the user to choose which one to invest in. If the user enters "saldo," the program will display the current balance. If the user enters an invalid company name, the program will prompt the user to try again.

If the user enters a valid company name, the program will prompt the user to enter the quantity of shares they want to buy. If the user has enough money to buy the shares, the program will deduct the amount from the user's balance and add the shares to the user's portfolio.

After buying the shares, the program updates the price of the shares with a random variation between -10% and +10%. The user can also choose to sell some of their shares at the current price.

When the user's balance reaches R$1000, the game ends.

## Code structure
```
The Main method is the entry point of the program.
The Dictionary<string, double> variable acoes stores the company names and stock prices.
The double variable saldo stores the user's balance.
The while loop runs until the user's balance reaches R$1000.
The program uses Console.ReadLine() to read user input and Console.WriteLine() to display messages.
The program uses try-catch blocks to handle exceptions.
```
