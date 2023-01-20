using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public float speed;
    public GameObject gameObject;
    
    void Start()
    {
        Debug.Log(message: new { speed });
        Debug.Log(message: new { gameObject.name });
    }
    
}
