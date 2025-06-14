using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundplayer : MonoBehaviour
{
    public AudioSource au;
    public AudioClip ac1;
    public AudioClip ac2;
    public AudioClip ac3, ac4, ac5, ac6;

    public void play1()
    {
        au.PlayOneShot(ac1);
    }
    public void play2()
    {
        au.PlayOneShot(ac2);
    }
    public void play3()
    {
        au.PlayOneShot(ac3);
    }
    public void play4()
    {
        au.PlayOneShot(ac4);
    }
    public void play5()
    {
        au.PlayOneShot(ac5);
    }
    public void play6()
    {
        au.PlayOneShot(ac6);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
