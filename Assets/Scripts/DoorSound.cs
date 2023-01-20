using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSound : MonoBehaviour
{
    [SerializeField] AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    public void AnimateSound()
    {
        source.Play();
    }
}
