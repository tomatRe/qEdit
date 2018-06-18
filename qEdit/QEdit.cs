//Angel Rebollo Berna

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class QEdit
{
    static string oldFileName;
    static string fileName;
    static int row = 1;
    static int column = 0;

    static string line = "";
    static ListOfStrings data;

    static int totalColumns = column;
    static int totalRows = row;

    /**
     * Renders the top bar with info abot the row and column 
     * where the cursor is at
     */
    private static void renderTopBar()
    {
        Console.SetCursorPosition(0, 0);

        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Gray;

        string infoText = "Row " + row + "  Column " + column;

        Console.Write(infoText);

        for (int i = 0; i < Console.WindowWidth - infoText.Length; i++)
        {
            Console.Write(" ");
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.BackgroundColor = ConsoleColor.DarkBlue;

        Console.SetCursorPosition(column, row);
    }

    /**
     * Called whenever the Up Arrow key is pressed.
     * 
     * Moves the cursor up a row if possible.
     */
    private static void UpArrowPressed()
    {
        if (row > 1)
        {
            if (line != "")
            {
                data.ReplaceLine(line, row - 1);
                if (data.Get(row - 1).Length > data.Get(row - 2).Length && data.Get(row - 2).Length > 0)
                {
                    column = data.Get(row - 2).Length;
                }

                line = data.Get(row - 2);

            }
            else
            {
                line = data.Get(row - 2);
            }
            System.Diagnostics.Debug.WriteLine(line);
            row--;
        }
    } 
    
    /**
     * Called whenever the Down Arrow key is pressed.
     * 
     * Moves the cursor down a row if possible.
     */
    private static void DownArrowPressed()
    {
        System.Diagnostics.Debug.WriteLine("DOWN: row = " + row + "; totalRows = " + totalRows);
        if (row < totalRows - 1)
        {
            if (line != "")
            {
                data.ReplaceLine(line, row - 1);

                if (data.Get(row - 1).Length > data.Get(row).Length)
                {
                    column = data.Get(row).Length;
                }
                line = data.Get(row);

            }
            else
            {
                line = data.Get(row);
            }
            System.Diagnostics.Debug.WriteLine(line);
            row++;
        }
    }
    
    /**
     * Called whenever the Enter key is pressed.
     * 
     * Moves the cursor down a row and adds a new line.
     */
    private static void EnterKeyPressed()
    {
        column = 0;
        totalRows++;
        row++;
        data.Add(line);
        line = "";
        Console.WriteLine();
    } 
    
    /**
     * Called whenever the Right arrow key is pressed.
     * 
     * Moves the cursor to the right one possition if possible
     */
    private static void RightArrowPressed()
    {
        if (column >= 0 && column < line.Length)
            column++;
    }
    
    /**
     * Called whenever the Left arrow key is pressed.
     * 
     * Moves the cursor to the left one possition if possible
     */
    private static void LeftArrowPressed()
    {
        if (column > 0)
            column--;
    }

    public static void inputText(int length)
    {
        ConsoleKeyInfo key;
        ListOfStrings data = new ListOfStrings();
        data.LoadPreviousData(oldFileName);

        if(data.Ammount != 0)
            row = data.Ammount;

        char lastCharacter = (char)0;
        bool exit = false;

        do
        {
            renderTopBar();

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    UpArrowPressed();
                    break;

                case ConsoleKey.DownArrow:
                    DownArrowPressed();
                    break;

                case ConsoleKey.LeftArrow:
                    LeftArrowPressed();
                    break;

                case ConsoleKey.RightArrow:
                    RightArrowPressed();
                    break;

                case ConsoleKey.Home:
                    column = 0;
                    break;

                case ConsoleKey.End:
                    column = line.Length;
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
                    if (oldFileName == null)
                    {
                        data.Add(line);
                        Console.SetCursorPosition(0, Console.WindowHeight - 2);
                        Console.Write("Name of the saved file? ");
                        fileName = Console.ReadLine();

                        data.SaveData(fileName, oldFileName);
                    }

                    exit = true;
                    break;

                case ConsoleKey.Enter:
                    EnterKeyPressed();
                    break;

                default:
                    if (column < length && line.Length < length)
                    {
                        lastCharacter = key.KeyChar;
                        column++;
                        line = line.Insert(column - 1, lastCharacter.ToString());
                        
                        //Deleting the previous characters of the modified line

                        Console.SetCursorPosition(0, row);
                        Console.Write(line);
                        for (int i = 0; i < Console.WindowWidth - line.Length; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.SetCursorPosition(column, row);
                    }
                    break;
            }

        } while (!exit);
        
    }


    public static void Main(string[] args)
    {
        data = new ListOfStrings();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();

        if (args.Length > 0)
            oldFileName = args[0];
            
        inputText(1024);

        Console.SetCursorPosition(0, Console.WindowHeight - 1);
    }

}