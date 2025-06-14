using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Redpepper : MonoBehaviour
{
    public float HP=100;
    public GameObject HPbar;
    public SpriteRenderer sr;
    public bool onDamage;
    public Animator anim;
    public string Standst;
    public string Damagest1;
    public string Damagest2;
    private int Damageanim=1;
    public string Gardst;
    public string Attack1st;
    public string Attack3st;
    public float timer;
    public float Attack1Time;
    public float AttackTime2;
    public bool onAttack;
    public DragMove noka;
    public bool muteki;
    public float MaxComnbo;
    public float ComboCounter;
    public float ComboTime;
    public float timer3;
    public string Attackst12;
    public string Attackst22;
    public string KnockOutst;
    public bool stop;
    public ShakeableTransform st;
    public Button button;
    public GameObject tori;
    public Animator torianim;
    public string torianimst;
    public AudioSource au;
    public AudioClip ac;
    public float cleartime;
    // Start is called before the first frame update
    void Start()
    {
        cleartime = 0;
        timer = Attack1Time;
        AttackTime2 = Attack1Time;
    }

    // Update is called once per frame
    void Update()
    {
        if (stop)
        {
            anim.speed = 0;
            return;
        }
        if (HP >= 70)
        {
         anim.speed = 1.2f;
        }
        else if (HP <= 69 && HP >= 40)
        {
            anim.speed = 1.4f;
        }
        else if (HP <= 39 && HP >= 0)
        {
            anim.speed = 1.7f;
        }
        else
        {
            anim.speed = 1;
        }

        if(HP<=0)
        {
            GameManeger.HP = noka.HP;
            GameManeger.Time = cleartime;
            noka.youwin = true;
            button.interactable = false;
        }
        else
        {
            cleartime+= Time.deltaTime;
        }
        if(anim.GetCurrentAnimatorStateInfo(0).IsName(Standst))
        {
            timer -= Time.deltaTime;
        }
      
        HPbar.transform.localScale = new Vector2(HP / 100, 1);
    }
    private void FixedUpdate()
    {
        
        if (HP <= 50 && HP >= 1)
        {
            sr.color = new Color(1, 0.5f, 0.5f);
       

        }
        else if (HP <= 0)
        {
            sr.color = new Color(1, 1, 1);
            anim.Play(KnockOutst);
            return;
        }
        if (onAttack)
        {
            noka.Damage();
        }
        if(timer<=0)
        {

            if (HP <= 50 && HP >= 1)
            {
               
                anim.Play(Attackst12);
                
                ComboCounter = 1;

            }
         
            else
            {
                if (Random.Range(1, 100) >= 50)
                {
                    anim.Play(Attack1st);
                    ComboCounter = 0;
                }
                else
                {
                    anim.Play(Attack3st);
                    ComboCounter = 0;
                }
            }
         
            timer = Attack1Time;
        }
       
    }
   public void Damage(float Damage)
    {

        if (muteki) return;
        if(MaxComnbo<=ComboCounter)
        {
            anim.Play(Gardst);
            return;
        }
        if(HP>=70)
        {
         
            HP -= Damage;
            DamageAnim();
            ComboCounter += 1;
        }
        else if(HP<=69&&HP>=40)
        {
            Attack1Time = AttackTime2 * 0.75f;
            HP -= Damage;
            DamageAnim();
            ComboCounter += 1;
        }
        else if(HP <= 39 && HP >= 0)
        {
            Attack1Time = AttackTime2 * 0.5f;
            HP -= Damage;
            DamageAnim();
            ComboCounter += 1;
        }
      if(HP<=0)
        {
            au.Stop();
            au.clip=ac;
            au.Play();
        }
    }
    private void DamageAnim()
    {
        if (Damageanim == 1)
        {
            anim.Play(Damagest1);
            Damageanim = 2;
        }
        else
        {
            anim.Play(Damagest2);
            Damageanim = 1;
        }
    }
    public void shake()
    {
        st.InduceStress(1);
    }
    public void tori1()
    {
        
        
        button.gameObject.SetActive(false);
        tori.SetActive(true);
        torianim.Play(torianimst);
    }
}
