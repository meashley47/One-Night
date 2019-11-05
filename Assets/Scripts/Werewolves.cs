using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Werewolves : MonoBehaviour
{
    public Button role1;
    public Button role2;
    public Button role3;
    public Text revealText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SomethingClicked(int roleNum)
    {
        role1.gameObject.SetActive(false);
        role2.gameObject.SetActive(false);
        role3.gameObject.SetActive(false);

        if (PlayerRoles.playerRoles[PlayerRoles.playerRoles.Length - 4 + roleNum].Contains("Doppel"))
        {
            revealText.text = "Doppelganger";
        }
        else
        {
            revealText.text = PlayerRoles.playerRoles[PlayerRoles.playerRoles.Length - 4 + roleNum];
        }
    }
}
