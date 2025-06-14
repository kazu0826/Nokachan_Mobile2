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
    public GameObject obj;
    public Redpepper red;
    public DragMove noka;
    
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
            obj.SetActive(false);
            pose = false;
            red.stop = false;
            noka.stop = false;
        }
        else
        {
            obj.SetActive(true);
            pose = true;
            img.sprite = sp;
            red.stop = true;
            noka.stop = true;
        }
  
    }
    public void YouLose()
    {

        obj.SetActive(true);
        pose = true;
        
        red.stop = true;
        noka.stop = true;
    }

}
