using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class GameManager : MonoBehaviour
{
    List<string> categories = new List<string>();
    [SerializeField]
    TextMeshProUGUI drawInfoText;

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
        StartGame();
    }

    void StartGame()
    {
        string category = categories[Random.Range(0, categories.Count)];
        string drawInfo = "Draw me a " + category;
        drawInfoText.text = drawInfo;
    }

    public void ClearDrawing()
    {
        GameObject[] lines = GameObject.FindGameObjectsWithTag("Line");
        foreach (GameObject line in lines)
        {
            Destroy(line);
        }
    }

    public void SkipToNextDrawing()
    {
        ClearDrawing();
        StartGame();
    }
}
