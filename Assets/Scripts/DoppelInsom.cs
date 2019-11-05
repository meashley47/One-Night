using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoppelInsom : MonoBehaviour
{
    public Text text;
    string newRole;

    // Start is called before the first frame update
    void Start()
    {
        newRole = "";
        for (int i = 0; i < PlayerRoles.originalRoles.Length; i++)
        {
            if (PlayerRoles.originalRoles[i] == "Doppelganger - Insomniac")
            {
                newRole = PlayerRoles.playerRoles[i];
            }
        }

        if (newRole == "Doppelganger - Insomniac")
        {
            text.text = "You are still the Doppelganger - Insomniac.";
        }
        else
        {
            text.text = "Your role was changed in the night! You are now the " + newRole + ".";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

