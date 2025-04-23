using System;
using System.Media;
using System.Threading;

// Voice greeting
    {
        Console.WriteLine("Playing WAV file using SoundPlayer...");
        PlayWavSound("greeting.wav"); // Must be a WAV file in the project directory
        Console.WriteLine("Welcome to the Cyber Security Awareness Bot!");
    }

    static void PlayWavSound(string filePath)
    {
        try
        {
            using (SoundPlayer player = new SoundPlayer(filePath))
            {
                player.Load();
                player.PlaySync(); // Waits until the sound finishes
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error playing sound: {ex.Message}");
        }
    }

// ASCII Art Logo
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(@"
   ____ ____   ___  ____  
  / ___| ___| / _ \| __ ) 
 | |   |___ \| | | |  _ \ 
 | |___|___) | | | | |_) |
  \____|____/|_/ \_|____/ 
   Security Cyber Awareness Bot
");
Console.ResetColor();

// User interaction
Console.Write("Hi there! What's your name? ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

string userName = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

Console.WriteLine($"Nice to meet you, {userName}! I'm here to help you stay safe online.");

// Main interaction loop
while (true)
{
    Console.Write($"{userName}, ask me something about cybersecurity (or type 'exit' to quit): ");
#pragma warning disable CS8602 // Dereference of a possibly null reference.

    string input = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Please ask a valid question.");
        continue;
    }
    if (input.Contains("how are you"))
        Console.WriteLine("I'm just code, but I'm always ready to help!");
    else if (input.Contains("purpose"))
        Console.WriteLine("I help users learn about cybersecurity and stay safe online.");
    else if (input.Contains("password"))
        Console.WriteLine("Use a long, unique password for each account. Password managers help a lot!");
    else if (input.Contains("phishing"))
        Console.WriteLine("Phishing emails often try to scare you. Always check the sender's address.");
    else if (input.Contains("safe browsing"))
        Console.WriteLine("Avoid suspicious links, and keep your browser up to date.");
    else if (input.Contains("exit"))
        break;
    else
        Console.WriteLine("I didn't quite understand that. Could you rephrase?");
}
