using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    // Start is called before the first frame update
    public List <string> questPartyMembers= new List<string>() { "����� �����", "������ ���", "������� ������"};
    void Start()
    {
        questPartyMembers.Add("����� ����");
        questPartyMembers.Insert(1, "����� �������");
        questPartyMembers.RemoveAt(0);
        questPartyMembers.Remove("������ ���");
        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
