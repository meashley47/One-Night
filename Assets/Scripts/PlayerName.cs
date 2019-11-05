using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public static string playerName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetNameInput(string name)
    {
        if (name == "")
        {
            Debug.Log("Loser, enter a real name");
            return;
        }
        playerName = name;
        Debug.Log("Welcome " + playerName);
        gameObject.GetComponent<DisableableButton>().EnableButton();
    }
}
