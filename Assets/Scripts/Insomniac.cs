using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Insomniac : MonoBehaviour
{
    public Text text;
    string newRole;

    // Start is called before the first frame update
    void Start()
    {
        newRole = "";
        for (int i = 0; i < PlayerRoles.originalRoles.Length; i++)
        {
            if (PlayerRoles.originalRoles[i] == "Insomniac")
            {
                newRole = PlayerRoles.playerRoles[i];
            }
        }

        if (newRole == "Insomniac")
        {
            text.text = "You are still the Insomniac.";
        }
        else
        {
            if (newRole.Contains("Doppel"))
            {
                text.text = "Your role was changed in the night! You are now the Doppelganger.";
            }
            else
            {
                text.text = "Your role was changed in the night! You are now the " + newRole + ".";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
