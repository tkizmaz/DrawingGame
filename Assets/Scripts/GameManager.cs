using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{
    List<string> categories = new List<string>();
    void Start()
    {
        string filePath = Application.dataPath + "/TextFiles/categories.txt";

        if (!File.Exists(filePath))
        {
            Debug.LogError("File not found: " + filePath);
        }

        else
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                categories.Add(line);
            }
        }
    }
}
