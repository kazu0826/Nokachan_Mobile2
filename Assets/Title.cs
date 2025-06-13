using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    public Animator anim;
    public string animst;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void title()

    {
        anim.gameObject.SetActive(true);
        Debug.Log("aa");
        anim.Play(animst);
    }
}
