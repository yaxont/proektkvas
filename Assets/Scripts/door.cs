using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public Animator dooranimator;
 private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Player")){
            dooranimator.SetTrigger("movedooor");
       }
    }
}
