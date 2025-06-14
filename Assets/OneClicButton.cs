using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneClicButton : MonoBehaviour
{
    public Button ui;
    // Start is called before the first frame update
    public void click()
    {
        ui.interactable = false;
    }
}
