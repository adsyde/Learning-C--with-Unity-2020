using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public string characterAction = "Attack";
    // Start is called before the first frame update
    void Start()
    {
        switch (characterAction)
        {
            case "Heal":
                Debug.Log("Potion sent.");
                break;
            case "Attack":
                Debug.Log("To arms");
                break;
            default:
                Debug.Log("Shields Up");
                break;
        }
    }


}
