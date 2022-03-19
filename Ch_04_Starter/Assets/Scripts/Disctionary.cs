using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disctionary : MonoBehaviour
{
    public Dictionary<string, int> itemInventory = new Dictionary<string, int>()
    {
        {"Зелье", 5},
        {"Антидот", 7},
        {"Аспирин", 1}
    };
    public int goldAmount = 6;
    // Start is called before the first frame update
    void Start()
    {
        itemInventory["Зелье"] = 2;
        itemInventory.Add("Меч лешрака", 10);
        itemInventory["Бинт"] = 2;
        if (itemInventory.ContainsKey("Аспирин"))
        {
            itemInventory["Аспирин"] = 3;
        }
        itemInventory.Remove("Антидот");
        //Debug.LogFormat("Items: {0}", itemInventory.Count);
        //foreach(KeyValuePair<string, int> kvp in itemInventory)
        //{
        //    Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
        //}
        foreach (KeyValuePair<string, int> kvp in itemInventory)
        {
            //Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
            if (kvp.Value <= goldAmount)
            {
                Debug.LogFormat("You can buy {0} for {1}g", kvp.Key, kvp.Value);
            }
            else
            {
                Debug.LogFormat("No money for {0} - {1}", kvp.Key, kvp.Value);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
