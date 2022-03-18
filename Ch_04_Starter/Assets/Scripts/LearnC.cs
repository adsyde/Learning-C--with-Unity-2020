using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnC : MonoBehaviour
{
    public bool pureOfHeard = true;
    public bool hasSecterIncantation = false;
    public string rareItem = "Нога Гоги";
    /*
    public bool weaponEquipped = true;
    public string weaponType = "Longsword";
    
    public bool hasDungeonKey = false;
    public string weaponType = "Arcane Staff";
    int currentGold = 79;
    */

    // Start is called before the first frame update
    void Start()
    {
        OpenTreasureChamber();
        /*
        if (weaponEquipped && weaponType == "Longsword")
        {
            Debug.Log("За Королеву!");
        }
        
        if (weaponEquipped)
        {
            if(weaponType == "Longsword")
            {
                Debug.Log("За Королеву!");
            }
            else
            {
                Debug.Log("что-за дичь?");
            }
        }
        else
        {
            Debug.Log("С кулаками на броню бросаться не вариант");
        }
        
        if (false == hasDungeonKey)
        {
            Debug.Log("Ты не можешь войти без священного ключа");
        }
        if (weaponType != "LongSword")
        {
            Debug.Log("Ты не можешь вооружиться этим типом оружия");
        }
        
        if (currentGold > 50)
        {
            Debug.Log($"Current gold is {currentGold}");
        }
        else if (currentGold <= 50)
        {
            Debug.Log("Он нищеброд");
        }
        
        if (!hasDungeonKey)
        {
            Debug.Log("You possess the sacred key - enter.");
        }
        else
        {
            Debug.Log("You have not provided yourself wothly, warrior.");
        }
        */
    }
    void OpenTreasureChamber()
    {
        if (pureOfHeard && rareItem == "Нога Гоги")
        {
            if (hasSecterIncantation)
            {
                Debug.Log("Ты унизитель");
            }
            else
            {
                Debug.Log("Ты лошок, но шанс есть");
            }
        }
        else if (!pureOfHeard && rareItem == "Нога Гоги")
        {
            Debug.Log("Ты полный лох, но что-то есть");
        }
        else
        {
            Debug.Log("Ты полный лох");
        }
    }
}
