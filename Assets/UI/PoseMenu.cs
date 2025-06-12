using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PoseMenu : MonoBehaviour
{
    public Image img;
    public Sprite sp;
    public Sprite sp2;
    public bool pose;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void yarinaosu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void owaru()
    {

    }
    public void Pose()
    {
        if(pose)
        {
            img.sprite = sp2;
            pose = false;
        }
        else
        {
            pose = true;
            img.sprite = sp;
        }
  
    }
    public void Close()
    {

        
    }
}
