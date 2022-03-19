using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IteratorFor : MonoBehaviour
{
    public List<string> questPartymembers = new List<string>
    { "Grim the Barbarian", "Merlin the Wise", "Sterling the Knight"};
    // Start is called before the first frame update
    void Start()
    {
        foreach (string partyMember in questPartymembers)
        {
            Debug.LogFormat("{0} - Here!", partyMember);
        }
        //for (int i = 0; i < questPartymembers.Count; i++)
        //{
        //    Debug.LogFormat("Index: {0} - {1}", i, questPartymembers[i]);
        //    if (questPartymembers[i] == "Merlin the Wise")
        //    {
        //        Debug.Log("Glad to see you Merlin!");
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
