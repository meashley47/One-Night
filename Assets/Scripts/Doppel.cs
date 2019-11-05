using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Doppel : MonoBehaviour
{
    public Text revealText;
    public Text roleText;
    public Text description;

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

    public Button drunkRole1;
    public Button drunkRole2;
    public Button drunkRole3;

    public Button TMplayer1;
    public Button TMplayer2;
    public Button TMplayer3;
    public Button TMplayer4;
    public Button TMplayer5;
    public Button TMplayer6;
    public Button TMplayer7;
    public Button TMplayer8;
    public Button TMplayer9;
    public Button TMplayer10;
    public Button TMplayer11;
    public Button TMplayer12;

    int TMfirstChoice = -1;

    public Button Rplayer1;
    public Button Rplayer2;
    public Button Rplayer3;
    public Button Rplayer4;
    public Button Rplayer5;
    public Button Rplayer6;
    public Button Rplayer7;
    public Button Rplayer8;
    public Button Rplayer9;
    public Button Rplayer10;
    public Button Rplayer11;
    public Button Rplayer12;

    public Button player;
    public Button unclaimed;
    public Button seerRole1;
    public Button seerRole2;
    public Button seerRole3;
    bool twoChosen = false;

    public Button Splayer1;
    public Button Splayer2;
    public Button Splayer3;
    public Button Splayer4;
    public Button Splayer5;
    public Button Splayer6;
    public Button Splayer7;
    public Button Splayer8;
    public Button Splayer9;
    public Button Splayer10;
    public Button Splayer11;
    public Button Splayer12;


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

            //But make sure to skip over the doppelganger themself!
            if (PlayerRoles.originalRoles[i] != "Doppelganger")
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
        for (int i = 0; i < 12; i++)
        {
            playerButtons[i].gameObject.SetActive(false);
        }

        int doppelIndex = -1;

        //Find the robber index
        for (int i = 0; i < PlayerRoles.playerRoles.Length; i++)
        {
            if (PlayerRoles.originalRoles[i] == "Doppelganger")
            {
                doppelIndex = i;
            }
        }

        for (int i = 0; i < PlayerRoles.players.Length; i++)
        {
            if (PlayerRoles.players[i] == playerButtons[roleNum].GetComponentInChildren<Text>().text)
            {
                roleText.text += " - " + PlayerRoles.playerRoles[i];

                //Change doppel's role
                PlayerRoles.playerRoles[doppelIndex] = "Doppelganger - " + PlayerRoles.playerRoles[i];
                PlayerRoles.originalRoles[doppelIndex] = PlayerRoles.playerRoles[doppelIndex];
                NewRole(PlayerRoles.playerRoles[i]);
            }
        }
    }

    public void NewRole(string newRole)
    {
        //New role won't have the "Doppelganger - " part included

        //If the role has a night action (either seer, robber, troublemaker, or drunk),
        //do that immediately and make it clear that the doppelgänger should NOT wake up 
        //when that real role is called later.

        //If the role is werewolf or mason, wake up with those roles.

        //If the role is villager, tanner, or hunter, do nothing.

        if (newRole == "Seer")
        {
            description.text = "You may look at one player's role, or two unclaimed roles. Do NOT wake up again later with the Seer.";

            player.gameObject.SetActive(true);
            unclaimed.gameObject.SetActive(true);
        }

        else if (newRole == "Robber")
        {
            description.text = "You may exchange roles with another player, but don't take the night action of that new role. Do NOT wake up again later in the night.";

            playerButtons[0] = Rplayer1;
            playerButtons[1] = Rplayer2;
            playerButtons[2] = Rplayer3;
            playerButtons[3] = Rplayer4;
            playerButtons[4] = Rplayer5;
            playerButtons[5] = Rplayer6;
            playerButtons[6] = Rplayer7;
            playerButtons[7] = Rplayer8;
            playerButtons[8] = Rplayer9;
            playerButtons[9] = Rplayer10;
            playerButtons[10] = Rplayer11;
            playerButtons[11] = Rplayer12;

            int j = 0;
            for (int i = 0; i < PlayerRoles.players.Length - 3; i++)
            {
                //Make a button for each player in the game and display that person's name

                //But make sure to skip over the doppel - robber themself!
                if (PlayerRoles.originalRoles[i] != "Doppelganger - Robber")
                {
                    playerButtons[j].gameObject.SetActive(true);
                    playerButtons[j].GetComponentInChildren<Text>().text = PlayerRoles.players[i];
                    j++;
                }
            }
        }

        else if (newRole == "Troublemaker")
        {
            description.text = "Choose two players whose roles you want to switch. Do NOT wake up again later with the Troublemaker.";

            playerButtons[0] = TMplayer1;
            playerButtons[1] = TMplayer2;
            playerButtons[2] = TMplayer3;
            playerButtons[3] = TMplayer4;
            playerButtons[4] = TMplayer5;
            playerButtons[5] = TMplayer6;
            playerButtons[6] = TMplayer7;
            playerButtons[7] = TMplayer8;
            playerButtons[8] = TMplayer9;
            playerButtons[9] = TMplayer10;
            playerButtons[10] = TMplayer11;
            playerButtons[11] = TMplayer12;


            int j = 0;
            for (int i = 0; i < PlayerRoles.players.Length - 3; i++)
            {
                //Make a button for each player in the game and display that person's name

                //But make sure to skip over the doppel - troublemaker themself!
                if (PlayerRoles.originalRoles[i] != "Doppelganger - Troublemaker")
                {
                    playerButtons[j].gameObject.SetActive(true);
                    playerButtons[j].GetComponentInChildren<Text>().text = PlayerRoles.players[i];
                    j++;
                }
            }
        }

        else if (newRole == "Drunk")
        {
            description.text = "Switch your role with one of the unclaimed roles below. Do NOT wake up again later with the Drunk.";

            drunkRole1.gameObject.SetActive(true);
            drunkRole2.gameObject.SetActive(true);
            drunkRole3.gameObject.SetActive(true);
        }

        else if (newRole == "Werewolf")
        {
            description.gameObject.SetActive(false);
            revealText.text += "Wake up with the other werewolves when their role is called.";
            revealText.gameObject.SetActive(true);
        }

        else if (newRole == "Mason")
        {
            description.gameObject.SetActive(false);
            revealText.text += "Wake up with the other masons when their role is called.";
            revealText.gameObject.SetActive(true);
        }

        else if (newRole == "Insomniac")
        {
            description.gameObject.SetActive(false);
            revealText.text += "You'll be told to wake up again later in the night, when the Doppelganger - Insomniac is called. Do NOT wake up with the regular Insomniac.";
            revealText.gameObject.SetActive(true);
        }
    }

    public void DrunkPicked(int roleNum)
    {
        drunkRole1.gameObject.SetActive(false);
        drunkRole2.gameObject.SetActive(false);
        drunkRole3.gameObject.SetActive(false);

        //Switch the drunk's role with the role they chose

        int drunkIndex = -1;

        //Find the drunk index
        for (int i = 0; i < PlayerRoles.playerRoles.Length; i++)
        {
            if (PlayerRoles.originalRoles[i] == "Doppelganger - Drunk")
            {
                drunkIndex = i;
            }
        }

        PlayerRoles.playerRoles[drunkIndex] = PlayerRoles.playerRoles[PlayerRoles.playerRoles.Length - 4 + roleNum];
        PlayerRoles.playerRoles[PlayerRoles.playerRoles.Length - 4 + roleNum] = "Doppelganger";
    }

    public void TroublemakerPicked(int roleNum)
    {
        if (TMfirstChoice >= 0)
        {
            TMChoseBoth(TMfirstChoice, roleNum);
        }
        else
        {
            TMfirstChoice = roleNum;
            playerButtons[roleNum].interactable = false;
        }
    }

    public void TMChoseBoth(int role1, int role2)
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

    public void RobberChose(int roleNum)
    {
        int robberIndex = -1;

        //Find the robber index
        for (int i = 0; i < PlayerRoles.playerRoles.Length; i++)
        {
            if (PlayerRoles.originalRoles[i] == "Doppelganger - Robber")
            {
                robberIndex = i;
            }
        }

        for (int i = 0; i < PlayerRoles.players.Length; i++)
        {
            if (PlayerRoles.players[i] == playerButtons[roleNum].GetComponentInChildren<Text>().text)
            {
                revealText.text += PlayerRoles.playerRoles[i];
                revealText.gameObject.SetActive(true);

                //Swap roles
                PlayerRoles.playerRoles[robberIndex] = PlayerRoles.playerRoles[i];
                PlayerRoles.playerRoles[i] = "Doppelganger";
            }
        }

        for (int i = 0; i < 12; i++)
        {
            playerButtons[i].gameObject.SetActive(false);
        }
    }

    public void SeerChose(bool playerChosen)
    {
        player.gameObject.SetActive(false);
        unclaimed.gameObject.SetActive(false);

        if (playerChosen)
        {
            //Add all player buttons to array
            playerButtons[0] = Splayer1;
            playerButtons[1] = Splayer2;
            playerButtons[2] = Splayer3;
            playerButtons[3] = Splayer4;
            playerButtons[4] = Splayer5;
            playerButtons[5] = Splayer6;
            playerButtons[6] = Splayer7;
            playerButtons[7] = Splayer8;
            playerButtons[8] = Splayer9;
            playerButtons[9] = Splayer10;
            playerButtons[10] = Splayer11;
            playerButtons[11] = Splayer12;

            int j = 0;
            for (int i = 0; i < PlayerRoles.players.Length - 3; i++)
            {
                //Make a button for each player in the game and display that person's name

                //But make sure to skip over the doppel - seer themself!
                if (PlayerRoles.originalRoles[i] != "Doppelganger - Seer")
                {
                    playerButtons[j].gameObject.SetActive(true);
                    playerButtons[j].GetComponentInChildren<Text>().text = PlayerRoles.players[i];
                    j++;
                }
            }
        }

        else
        {
            seerRole1.gameObject.SetActive(true);
            seerRole2.gameObject.SetActive(true);
            seerRole3.gameObject.SetActive(true);
        }
    }

    public void SeerPersonPicked(int roleNum)
    {
        for (int i = 0; i < PlayerRoles.players.Length; i++)
        {
            if (PlayerRoles.players[i] == playerButtons[roleNum].GetComponentInChildren<Text>().text)
            {
                revealText.text = PlayerRoles.playerRoles[i];
            }
        }

        for (int i = 0; i < 12; i++)
        {
            playerButtons[i].gameObject.SetActive(false);
        }
    }

    public void SeerSomethingClicked(int roleNum)
    {
        if (twoChosen)
        {
            seerRole1.gameObject.SetActive(false);
            seerRole2.gameObject.SetActive(false);
            seerRole3.gameObject.SetActive(false);

            revealText.text += PlayerRoles.playerRoles[PlayerRoles.playerRoles.Length - 4 + roleNum];
        }

        //First pick, save which button it was
        else
        {
            twoChosen = true;

            if (roleNum == 1)
            {
                seerRole1.interactable = false;
            }
            else if (roleNum == 2)
            {
                seerRole2.interactable = false;
            }
            else
            {
                seerRole3.interactable = false;
            }

            revealText.text = PlayerRoles.playerRoles[PlayerRoles.playerRoles.Length - 4 + roleNum] + "\n";
        }
    }


}