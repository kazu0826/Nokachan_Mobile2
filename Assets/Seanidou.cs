using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Seanidou : MonoBehaviour
{
    public string seanst;
    public bool idou = false;
    public float time;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(idou)
        {
            time -= Time.deltaTime;
            if(time<=0)
            {
                SceneManager.LoadScene(seanst);
            }
        }
    }
    public void seanidou()
    {
        if(panel!=null)
        {
            panel.SetActive(true);
        }
        idou = true;
    }

}
