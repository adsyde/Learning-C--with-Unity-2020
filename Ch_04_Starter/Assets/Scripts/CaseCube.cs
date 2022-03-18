using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseCube : MonoBehaviour
{
    public int diceRoll = 7;
    // Start is called before the first frame update
    void Start()
    {
        switch (diceRoll)
        {
            case 7:
                Debug.Log("nice shot");
                break;
            case 15:
                Debug.Log("Mediocre damage, not bad.");
                break;
            case 20:
                Debug.Log("Critical hit, the creature goes down!");
                break;
            default:
                Debug.Log("You completely missed and fell on your face.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
