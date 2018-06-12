//Angel Rebollo Berna

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class QEdit
{

    public static void inputText(int length)
    {
        Console.Clear();
        ConsoleKeyInfo key;
        List<string> data = new List<string>();

        char lastCharacter = (char)0;
        string fileName;
        bool exit = false;
        string line = "";

        do
        {
            //The contrast between the text and background are too bad
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            //when i make the design i´ll make sure to 
            //flood the window with the respective colors

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    break;

                case ConsoleKey.DownArrow:
                    break;

                case ConsoleKey.Escape:
                    break;

                case ConsoleKey.PageDown:
                    break;

                case ConsoleKey.PageUp:
                    break;

                case ConsoleKey.F10:
                    Console.Write("Name of the saved file? ");
                    fileName = Console.ReadLine();
                    ListOfStrings save = new ListOfStrings();

                    exit = true;
                    break;

                case ConsoleKey.Enter:
                    length = 80;
                    Console.WriteLine();
                    break;

                default:
                    if (length >= 0)
                    {
                        lastCharacter = key.KeyChar;
                        length--;
                        Console.Write(lastCharacter);
                        line += lastCharacter;
                    }
                    break;
            }

        } while (!exit);

        data.Add(line);
    }

    
    public static void Main(string[] args)
    {

        ListOfStrings data = new ListOfStrings();

        string fileName;
        if (args.Length > 0)
            fileName = args[0];

        inputText(80);
    }

}

