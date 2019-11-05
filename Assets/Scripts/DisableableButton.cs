using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableableButton : MonoBehaviour
{
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        button.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DisableButton()
    {
        button.interactable = false;
    }

    public void EnableButton()
    {
        button.interactable = true;
    }
}
