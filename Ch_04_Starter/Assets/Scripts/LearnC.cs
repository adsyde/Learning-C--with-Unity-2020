using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnC : MonoBehaviour
{
    public bool pureOfHeard = true;
    public bool hasSecterIncantation = false;
    public string rareItem = "���� ����";
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
            Debug.Log("�� ��������!");
        }
        
        if (weaponEquipped)
        {
            if(weaponType == "Longsword")
            {
                Debug.Log("�� ��������!");
            }
            else
            {
                Debug.Log("���-�� ����?");
            }
        }
        else
        {
            Debug.Log("� �������� �� ����� ��������� �� �������");
        }
        
        if (false == hasDungeonKey)
        {
            Debug.Log("�� �� ������ ����� ��� ���������� �����");
        }
        if (weaponType != "LongSword")
        {
            Debug.Log("�� �� ������ ����������� ���� ����� ������");
        }
        
        if (currentGold > 50)
        {
            Debug.Log($"Current gold is {currentGold}");
        }
        else if (currentGold <= 50)
        {
            Debug.Log("�� ��������");
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
        if (pureOfHeard && rareItem == "���� ����")
        {
            if (hasSecterIncantation)
            {
                Debug.Log("�� ���������");
            }
            else
            {
                Debug.Log("�� �����, �� ���� ����");
            }
        }
        else if (!pureOfHeard && rareItem == "���� ����")
        {
            Debug.Log("�� ������ ���, �� ���-�� ����");
        }
        else
        {
            Debug.Log("�� ������ ���");
        }
    }
}
