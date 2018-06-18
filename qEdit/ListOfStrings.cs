//v0.01 - 12/06/18 - Creation of the class

using System;
using System.Collections.Generic;
using System.IO;


class ListOfStrings
{
    public List<string> saveData;
    int amount;
    string currentString;

    public ListOfStrings()
    {
        saveData = new List<string>();
        amount = 0;
    }

    public string Get(int n)
    {
        return saveData[n];
    }

    public int Ammount
    {
        get { return amount; }
        set { Ammount = value; }
    }

    public void Add(string s)
    {
        saveData.Add(s);
        amount = saveData.Count;
    }

    public void ReplaceLine(string line, int pos)
    {
        if(pos >= 0 && pos <= saveData.Count)
        {
            saveData[pos - 1] = line;
        }
        else
        {
            Add(line);
        }
            
    }


    public void LoadPreviousData(string fileName)
    {

        if (File.Exists(fileName))
        {
            try
            {
                StreamReader myFile = File.OpenText(fileName);
                string line = "";
                do
                {
                    line = myFile.ReadLine();
                    saveData.Add(line);
                    Console.WriteLine(line);
                    amount++;
                } while (line != null);
                myFile.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not accessible");
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oooops... " + e.Message);
            }
        }
    }

    public void SaveData(string fileName, string oldFileName)
    {
        try
        {
            if (oldFileName == null)
            {
                CreateFile(fileName);
            }
            else if(oldFileName != fileName)
            {
                CreateFile(fileName);
            }
            else
                AppendFile(fileName);
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not accessible");
        }
        catch (IOException e)
        {
            Console.WriteLine("I/O error: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Oooops... " + e.Message);
        }
    }

    private void CreateFile(string fileName)
    {
        StreamWriter myFile = File.CreateText(fileName);
        for (int i = 0; i < Ammount; i++)
        {
            myFile.WriteLine(saveData[i]);
        }
        myFile.Close();
    }

    private void AppendFile(string fileName)
    {
        StreamWriter myFile = File.AppendText(fileName);
        for (int i = 0; i < Ammount; i++)
        {
            myFile.WriteLine(saveData[i]);
        }
        myFile.Close();
    }
}
