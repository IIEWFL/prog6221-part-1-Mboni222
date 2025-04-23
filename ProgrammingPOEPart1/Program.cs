using System;
using System.Speech.Synthesis;
using System.Threading;

namespace ProgrammingPOEPart1
{
    class Program
    {
        static SpeechSynthesizer synth = new SpeechSynthesizer();
        static void Main(string[] args)
        {
            Console.Clear();
            DisplayAsciiArt();

            synth.SelectVoiceByHints(VoiceGender.Female);
            synth.Rate = 0;
            synth.Volume = 100;

            SpeakAndPrint("Hello! Welcome to the cybersecurity awareness bot.");
            SpeakAndPrint("I am your assistant.");
            SpeakAndPrint("I am here to assist you to stay safe online.");

            chatLoop();
        }

        static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            string asciiArt = @"
     _____ _   _ _____ _____ _____ _____  _______     __
    |_   _| \ | |_   _|  ___|  ___|  ___|/  ___\ \   / /
      | | |  \| | | | | |_  | |_  | |_   \ `--. \ \_/ / 
      | | | . ` | | | |  _| |  _| |  _|   `--. \ \   /
      | | | |\  | |_| |_|   |_|   | |    /\__/ /  | |
      \_/ \_| \_/ \__/\_|   \_|   |_/    \____/   |_|
            ";
            Console.WriteLine(asciiArt);
        }
        static void SpeakAndPrint(string message)
        {
            Console.WriteLine(message);
            synth.Speak(message);
        }
        static void RespondToUser(string userInput)
        {
            string response = "";
            if (userInput.Contains("hello") || userInput.Contains("hi"))
            {
                response = "Hello! How can I assist you today?";
            }
            else if (userInput.Contains("help"))
            {
                response = "I can provide information on cybersecurity best practices.";
            }
            else if (userInput.Contains("what is cybersecurity?"))
            {
                response = "It is the practice of protecting programs, systems and networks from digital attacks.";
            }
            else if (userInput.Contains("what is phishing?"))
            {
                response = "It is an attack that tries to steal your money or identity by getting you to reveal your password.";
            }
            else if (userInput.Contains("what is Ransomware?"))
            {
                response = "It is malicious software that is intended to block an account until a certain amount is paid";
            }
            else if (userInput.Contains("name 5 cyber attacks"))
            {
                response = "Phishing,Ransomware,Spyware,Trojans and Spoofing.";
            }
            else if (userInput.Contains("how are you?"))
            {
                response = "I am doing quite well thank you for asking. How may i assist you today?";
            }
            else if (userInput.Contains("bye"))
            {
                response = "Goodbye! Stay safe online!";
                SpeakAndPrint(response);
                Environment.Exit(0);
            }
            else
            {
                response = "I am afraid I do not understand that. Could you please rephrase or re-type what you said";
            }
            SpeakAndPrint(response);


        }

        static void chatLoop()
        {
            while (true)
            {
                Console.Write("You: ");
                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    SpeakAndPrint("Please enter something for me to respond to.");
                    continue;
                }

                if (userInput.ToLower() == "exit")
                {
                    SpeakAndPrint("Goodbye! Stay safe online!");
                    break;
                }

                RespondToUser(userInput);

            }
        }
    }
}
//References

//Author - W3schools
//Date Accessed : 22 April 2025
//URL: https://www.w3schools.com/

//Author - GeeksforGeeks
//Date Accessed : 22 April 2025 
//URL : https://www.geeksforgeeks.org/

//Author - JetBrains
//Date Accessed : 22 April 2025
//jetforbrain - https://www.jetbrains.com 