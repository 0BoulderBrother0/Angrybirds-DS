using System.Collections.Generic;
using UnityEngine;

public class Utility
{

    public static Dictionary<string, string> saveData = new Dictionary<string, string>();

    public static void PrintSaveDataToConsole()
    {
        Debug.Log("Levels cleared:");

        foreach (var item in saveData) 
        {
            Debug.Log($"{item.Key}: {item.Value}");
        }
    }

}
