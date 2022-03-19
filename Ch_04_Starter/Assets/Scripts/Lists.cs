using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    // Start is called before the first frame update
    public List <string> questPartyMembers= new List<string>() { "Конон Варва", "Саурон маг", "Леголас лучник"};
    void Start()
    {
        questPartyMembers.Add("Лютик бард");
        questPartyMembers.Insert(1, "Вивек владыка");
        questPartyMembers.RemoveAt(0);
        questPartyMembers.Remove("Саурон маг");
        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
