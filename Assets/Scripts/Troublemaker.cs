using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Troublemaker : MonoBehaviour
{
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

    int firstChoice = -1;

    // Start is called before the first frame update
    void Start()
    {
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

            //But make sure to skip over the troublemaker themself!
            if (PlayerRoles.originalRoles[i] != "Troublemaker")
            {
                playerButtons[j].gameObject.SetActive(true);
                playerButtons[j].GetComponentInChildren<Text>().text = PlayerRoles.players[i];
                j++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Chose(int roleNum)
    {
        if (firstChoice >= 0)
        {
            ChoseBoth(firstChoice, roleNum);
        }
        else
        {
            firstChoice = roleNum;
            playerButtons[roleNum].interactable = false;
        }
    }

    public void ChoseBoth(int role1, int role2)
    {
        int switch1 = -1;
        int switch2 = -1;

        for (int i = 0; i < PlayerRoles.players.Length; i++)
        {
            if (PlayerRoles.players[i] == playerButtons[role1].GetComponentInChildren<Text>().text)
            {
                switch1 = i;
            }

            else if (PlayerRoles.players[i] == playerButtons[role2].GetComponentInChildren<Text>().text)
            {
                switch2 = i;
            }
        }

        for (int i = 0; i < 12; i++)
        {
            playerButtons[i].gameObject.SetActive(false);
        }

        //Swap roles
        string temp = PlayerRoles.playerRoles[switch1];
        PlayerRoles.playerRoles[switch1] = PlayerRoles.playerRoles[switch2];
        PlayerRoles.playerRoles[switch2] = temp;
    }
}
