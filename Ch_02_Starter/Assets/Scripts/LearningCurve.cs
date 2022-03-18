using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private int currenaAge = 30;
    public int addedAge = 1;
    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
    }

    /// <summary>
    /// Computes a modifued age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(currenaAge + addedAge);
    }
    
}
