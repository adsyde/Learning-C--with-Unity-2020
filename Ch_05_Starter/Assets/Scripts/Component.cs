using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component : MonoBehaviour
{
    //private Transform camTransform;
    public GameObject directionLight;
    private Transform lightTransform;
    // Start is called before the first frame update
    void Start()
    {
        //directionLight = GameObject.Find("Directional Light");
        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
        //camTransform = this.GetComponent<Transform>();
        //Debug.Log(camTransform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
