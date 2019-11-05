using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seer : MonoBehaviour
{
    public Button player;
    public Button unclaimed;
    public Button role1;
    public Button role2;
    public Button role3;
    public Text revealText;
    bool twoChosen = false;

    public Button[] playerButtons = new Button[12];
    public Button player1;
    public Button player2;
    public Button player3;
    public Button player4;
    public Button player5;
    public Button player6;
    public Button player7;
    public Button player8;
    public Button player9;
    public Button player10;
    public Button player11;
    public Button player12;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Chose(bool playerChosen)
    {
        player.gameObject.SetActive(false);
        unclaimed.gameObject.SetActive(false);

        if (playerChosen)
        {
            //Add all player buttons to array
            playerButtons[0] = player1;
            playerButtons[1] = player2;
            playerButtons[2] = player3;
            playerButtons[3] = player4;
            playerButtons[4] = player5;
            playerButtons[5] = player6;
            playerButtons[6] = player7;
            playerButtons[7] = player8; 
            playerButtons[8] = player9;
            playerButtons[9] = player10;
            playerButtons[10] = player11;
            playerButtons[11] = player12;

            int j = 0;
            for (int i = 0; i < PlayerRoles.players.Length - 3; i++)
            {
                //Make a button for each player in the game and display that person's name

                //But make sure to skip over the seer themself!
                if (PlayerRoles.originalRoles[i] != "Seer")
                {
                    playerButtons[j].gameObject.SetActive(true);
                    playerButtons[j].GetComponentInChildren<Text>().text = PlayerRoles.players[i];
                    j++;
                }
            }
        }

        else
        {
            role1.gameObject.SetActive(true);
            role2.gameObject.SetActive(true);
            role3.gameObject.SetActive(true);
        }
    }

    public void PersonPicked(int roleNum)
    {
        for (int i = 0; i < PlayerRoles.players.Length; i++)
        {
            if (PlayerRoles.players[i] == playerButtons[roleNum].GetComponentInChildren<Text>().text)
            {
                if (PlayerRoles.playerRoles[i].Contains("Doppel"))
                {
                    revealText.text = "Doppelganger";
                }
                else
                {
                    revealText.text = PlayerRoles.playerRoles[i];
                }
            }
        }

        for (int i = 0; i < 12; i++)
        {
            playerButtons[i].gameObject.SetActive(false);
        }
    }

    public void SomethingClicked(int roleNum)
    {
        if (twoChosen)
        {
            role1.gameObject.SetActive(false);
            role2.gameObject.SetActive(false);
            role3.gameObject.SetActive(false);

            if (PlayerRoles.playerRoles[PlayerRoles.playerRoles.Length - 4 + roleNum].Contains("Doppel"))
            {
                revealText.text += "Doppelganger";
            }
            else
            {
                revealText.text += PlayerRoles.playerRoles[PlayerRoles.playerRoles.Length - 4 + roleNum];
            }
        }

        //First pick, save which button it was
        else
        {
            twoChosen = true;

            if (roleNum == 1)
            {
                role1.interactable = false;
            }
            else if (roleNum == 2)
            {
                role2.interactable = false;
            }
            else
            {
                role3.interactable = false;
            }

            if (PlayerRoles.playerRoles[PlayerRoles.playerRoles.Length - 4 + roleNum].Contains("Doppel"))
            {
                revealText.text = "Doppelganger\n";
            }
            else
            {
                revealText.text = PlayerRoles.playerRoles[PlayerRoles.playerRoles.Length - 4 + roleNum] + "\n";
            }
        }
    }
}
