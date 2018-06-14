//Angel Rebollo Berna

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class QEdit
{

    static string fileName;
    static int column = 1;
    static int row = 0;

    public static void inputText(int length)
    {
        ConsoleKeyInfo key;
        ListOfStrings data = new ListOfStrings();

        //Total colums are the written ones, and the colum are the position

        int totalColumns = column;
        int totalRows = row;

        char lastCharacter = (char)0;
        bool exit = false;
        string line = "";

        do
        {
            Console.SetCursorPosition(0, 0);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;

            string infoText = "Column " + column + "  Row " + row;

            Console.Write(infoText);

            for (int i = 0; i < Console.WindowWidth-infoText.Length; i++)
            {
                Console.Write(" ");
            }

            Console.SetCursorPosition(row, column);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    break;

                case ConsoleKey.DownArrow:
                    break;

                case ConsoleKey.LeftArrow:
                    if (row > 0)
                        row--;
                    break;

                case ConsoleKey.RightArrow:
                    if (row < line.Length)
                        row++;
                    break;

                case ConsoleKey.Backspace:
                    break;

                case ConsoleKey.Escape:
                    break;

                case ConsoleKey.PageDown:
                    break;

                case ConsoleKey.PageUp:
                    break;

                case ConsoleKey.F10:
                    if (fileName == null)
                    {
                        Console.SetCursorPosition(0, Console.WindowHeight - 2);
                        Console.Write("Name of the saved file? ");
                        fileName = Console.ReadLine();
                    }

                    //TODO save to a file

                    exit = true;
                    break;

                case ConsoleKey.Enter:
                    row = 0;
                    totalColumns++;
                    column++;
                    line = "";
                    Console.WriteLine();
                    break;

                default:
                    if (row < length)
                    {
                        lastCharacter = key.KeyChar;
                        row++;
                        line = line.Insert(row-1, lastCharacter.ToString());
                    }
                    break;
            }

            //Deleting the previous characters of the modified line

            Console.SetCursorPosition(0, column);
            Console.Write(line);
            for (int i = 0; i < Console.WindowWidth - line.Length; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(row, column);

            data.Add(line);

        } while (!exit);
        
    }


    public static void Main(string[] args)
    {

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();

        if (args.Length > 0)
            fileName = args[0];
            
        inputText(80);

        Console.SetCursorPosition(0, Console.WindowHeight - 1);
    }

}