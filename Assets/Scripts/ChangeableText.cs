using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeableText : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "Choose " + (GameController.numPlayers + 3) + " roles";
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
