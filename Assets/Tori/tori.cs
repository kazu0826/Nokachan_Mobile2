using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tori : MonoBehaviour
{
    static bool retry=false;
    public Animator anim;
    [SerializeField] private string redpepperst;
    [SerializeField] private string redpepper_re_st;
    [SerializeField] private string youwin;

   public Redpepper red;
   public DragMove dm;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        if (retry)
        {
            anim.Play(redpepper_re_st);
        }
        else
        {
            anim.Play(redpepperst);
         
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Endblad()
    {
        red.stop = false;
        dm.stop = false;
        button.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
