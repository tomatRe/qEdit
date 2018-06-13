//v0.01 - 12/06/18 - Creation of the class

using System;
using System.Collections.Generic;
using System.Text;


class ListOfStrings
{
    List<string> saveData;
    int amount;
    string currentString;

    public ListOfStrings()
    {
        saveData = new List<string>();
    }

    public string GetcurrentString()
    {
        return currentString;
    }

    public int GetAmount()
    {
        return amount;
    }

    public void Add(string s)
    {
        saveData.Add(s);
    }
}
