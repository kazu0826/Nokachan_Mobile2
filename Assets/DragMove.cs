using UnityEngine;
using TMPro;

public class DragMove : MonoBehaviour
{
	public float HP;
	[SerializeField] private float slideSpeed = 2f; //横移動のスピード。Inspector等で設定
	public float onePower = 5;
	public float twoPower = 8;
	public Redpepper red;
	public TextMeshProUGUI tm = null;
	public TextMeshProUGUI tm2 = null;
	public Animator anim;
	public string standst;
	public string leftst;
	public string rightst;
	public string attackst;
	public string attackst2;
	public string damagest;
	public bool hanten=false;
	public bool touchi = false;
	private float touchistartposx;
	private float touchipos;
	public float touchitime;
	private float timer;
	private float pos;
	public float touchidis;
	public float touchPositiony;
	public bool tapNG = false;
	public float onetwotime;
	public float timer2;
	public ShakeableTransform st;
	public float safe;
	public bool onDamage;
	public string KnockOutst;
	public SpriteRenderer HPUI;
	public Sprite UI2;
	public Sprite UI1;
	public Sprite UI0;
	public bool stop = false;
	
	private void Update()
	{
	
	}
    private void FixedUpdate()
    {
	
		if(stop)
        {
			return;
        }
		PlayerInput();

		if (HP == 2)
		{
			HPUI.sprite = UI2;
		}
		else if (HP == 1)
		{
			HPUI.sprite = UI1;
		}
		else if (HP == 0)
		{
			HPUI.sprite = UI0;
		}
		timer -= Time.deltaTime;
		timer2 -= Time.deltaTime;
	}
    private void PlayerInput()
	{

		if (onDamage) return;
		//もし入力がなかったらreturnする
		if (Input.touchCount <= 0)
        {
			touchi = false;
			timer = 0;
			return;
        }

		 touchPositiony = Input.GetTouch(0).position.y;
		
		
	
	
		if(touchPositiony<=Screen.height*0.4)
        {
			touchistartposx = Input.GetTouch(0).position.x;


			if (!touchi)
			{

				if (tm != null)
				{
					tm.text = string.Format("移動速度: {0}", Input.GetTouch(0).position);

					touchi = true;
				}

				timer = touchitime;
			}
			slide();
		}
		else
        {
			touchistartposx = Input.GetTouch(0).position.x;
			if (!touchi)
			{

				if (tm != null)
				{
					tm.text = string.Format("移動速度: {0}", Input.GetTouch(0).position);

					touchi = true;
				}

				timer = touchitime;
			}
			tap();
        }
		touchi = false;
		timer = 0;






	}
	private void tap()
    {
		
		if (Input.GetTouch(0).phase != TouchPhase.Ended || timer < 0) return;

		if (touchistartposx <= Screen.width *0.2)
		{
			tm2.text = string.Format("移動速度: {0}", Input.GetTouch(0).position.y);
			if (tapNG) return;
			anim.Play(leftst);

		}
		else if (touchistartposx >= Screen.width *0.8)
		{
			tm2.text = string.Format("移動速度: {0}", Input.GetTouch(0).position.y);
			if (tapNG) return;

			anim.Play(rightst);
		}
		else
        {
			if (tapNG) return;
			if(timer2>0)
            {
				anim.Play(attackst2);
				red.Damage(twoPower);
				timer2 = 0;

			}
			else
            {
				red.Damage(onePower);
				anim.Play(attackst);
				timer2 = onetwotime;
			}

		}
	
	}
	private void slide()
    {

		if (Input.GetTouch(0).phase != TouchPhase.Ended || timer < 0) return;
	
		if (touchistartposx <= Screen.width / 2)
		{
			tm2.text = string.Format("移動速度: {0}", Input.GetTouch(0).position.y);
			if (tapNG) return;
			anim.Play(leftst);

		}
		else if (touchistartposx >= Screen.width / 2)
		{
			tm2.text = string.Format("移動速度: {0}", Input.GetTouch(0).position.y);
			if (tapNG) return;

			anim.Play(rightst);
		}
		
	}
	public void Damage()
    {
		if (transform.position.x <= 0 - safe || transform.position.x > 0 + safe) return;
		st.InduceStress(1);
		if(!onDamage)
        {
			HP -= 1;
		}
		onDamage = true;
	
		
		if(HP<=0)
        {
			anim.Play(KnockOutst);
		}
		else
        {
			anim.Play(damagest);
		}
    }
}