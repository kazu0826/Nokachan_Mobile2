using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    public Animator anim;
    public string udemaest;
    public string heta;
    public string maamaa;
    public string umai;
    public string saikou;
    public string owari;
    public AudioSource au;
    public float time;
    public Soundplayer sp;
    // Start is called before the first frame update
    private void Update()
    {
        if(au.time>=time)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName(udemaest)) judge();
        }
    }
    public void judge()
    {
       
        if (anim.GetCurrentAnimatorStateInfo(0).IsName(udemaest))
        {
            au.time = time;
            au.Play();
            if (GameManeger.HP>=3)
            {
                if (GameManeger.Time <= 30) 
                {
                    anim.Play(saikou);

                    sp.play1();
                }
                else
                {
                    anim.Play(umai);
                    sp.play2();
                }
            }
            else if(GameManeger.HP==2)
            {
                sp.play2();
                anim.Play(maamaa);
            }
            else
            {

                anim.Play(heta);
            }
          
        }
        else
        {
            au.volume = 0;
            anim.Play(owari);
        }
            
    }

}
