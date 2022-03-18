using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Integer variables
    private int currentAge = 30;
    public int addedAge = 1;

    public float pi = 3.14f;
    public string firstName = "Harrison";
    public bool isAuthor = true;

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
        int playerLevel = 32;
        string playerName = "Goga";
        GenerateCharacter(playerName, playerLevel);
        int nextSkillLever = GenerateCharacter(playerName, playerLevel);
        Debug.Log(nextSkillLever);
        Debug.Log(GenerateCharacter(playerName, playerLevel));

    }

    public int GenerateCharacter(string name, int level)
    {
        //Debug.Log("Character: Spike");
        //Debug.LogFormat("Characeter: {0} - Level: {1}", name, level);
        return level + 5;
    }

    /// <summary>
    /// Computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log($"A string can have variables like {firstName} inserted directly");
        //Debug.Log(firstName * pi);
    }
}
