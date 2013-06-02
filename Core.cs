using System;
using System.Diagnostics;

namespace Restarter
{
    internal class Core
    {
        private static void Main()
        {
            Console.CursorVisible = false;
            Console.Title = "Emulator Restarter";
            Writer("Coded by Clawed @ RaGEZONE", ConsoleColor.White);
            Writer("Starting Emulator Restarter", ConsoleColor.White);
            StartEmulator();
        }

        private static void StartEmulator()
        {
            try
            {
                try
                {
                    Process Process = new Process
                    {
                        StartInfo = { FileName = "Butterfly Emulator.exe" }
                    };
                    Process.Start();
                    Process.WaitForExit();
                    Console.Beep();
                    StartEmulator();
                }
                catch (Exception)
                {
                    Writer("Butterfly Emulator.exe does not seem to be in same directory.", ConsoleColor.Red);
                }
                try
                {
                    Process Process = new Process
                    {
                        StartInfo = { FileName = "Phoenix 3.0.exe" }
                    };
                    Process.Start();
                    Process.WaitForExit();
                    Console.Beep();
                    StartEmulator();
                }
                catch (Exception)
                {
                    Writer("Phoenix 3.0.exe does not seem to be in same directory.", ConsoleColor.Red);
                }
            }
            catch (Exception E)
            {
                Writer(E.Message, ConsoleColor.Red);
            }
            while(true)
            {
            }
        }

        private static void Writer(string Text, ConsoleColor Color)
        {
            DateTime Time = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(Time.ToString("HH:MM"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]");
            Console.Write(" \x00bb ");
            Console.ForegroundColor = Color;
            Console.Write(Text);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
