using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static int numPlayers = 0;
    public static int rolesRevealed = 0;
    Scene scene;
    public static string[] rolesInGame;
    public static string[] rolesToAssign;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetInput(string num)
    {
        numPlayers = int.Parse(num);
    }

    public void StartOver()
    {
        rolesRevealed = 0;
        PlayerRoles.index = 0;
        SceneManager.LoadScene(0);
    }

    public void SpecificScene(int num)
    {
        SceneManager.LoadScene(num);
    }

    public void NextScene()
    {
        scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex + 1);
    }

    public void LastScene()
    {
        rolesRevealed = 0;
        scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex - 1);
    }

    public void ThisSceneAgain()
    {
        scene = SceneManager.GetActiveScene();
        rolesRevealed++;

        if (rolesRevealed < numPlayers)
        {
            SceneManager.LoadScene(scene.buildIndex);
        }

        else
        {
            NextScene();
        }
    }

    public void SetRolesInGame()
    {
        rolesInGame = new string[numPlayers + 3];
        rolesToAssign = new string[numPlayers + 3];
        int j = 0;

        //Doppelganger, drunk, hunter, insomniac, mason, mason, minion, robber
        //Seer, tanner, troublemaker, villager, villager, villager, werewolf, werewolf
        for (int i = 0;  i < HighlightRole.roleArray.Length; i++)
        {
            if (HighlightRole.roleArray[i])
            {
                //Switch statement to get the right role name
                switch(i)
                {
                    case 0:
                        rolesInGame[j] = "Doppelganger";
                        break;
                    case 1:
                        rolesInGame[j] = "Drunk";
                        break;
                    case 2:
                        rolesInGame[j] = "Hunter";
                        break;
                    case 3:
                        rolesInGame[j] = "Insomniac";
                        break;
                    case 4:
                        rolesInGame[j] = "Mason";
                        break;
                    case 5:
                        rolesInGame[j] = "Mason";
                        break;
                    case 6:
                        rolesInGame[j] = "Minion";
                        break;
                    case 7:
                        rolesInGame[j] = "Robber";
                        break;
                    case 8:
                        rolesInGame[j] = "Seer";
                        break;
                    case 9:
                        rolesInGame[j] = "Tanner";
                        break;
                    case 10:
                        rolesInGame[j] = "Troublemaker";
                        break;
                    case 14:
                        rolesInGame[j] = "Werewolf";
                        break;
                    case 15:
                        rolesInGame[j] = "Werewolf";
                        break;
                    default:
                        rolesInGame[j] = "Villager";
                        break;
                }

                j++;
            }
        }

        for (int i = 0; i < rolesInGame.Length; i++)
        {
            rolesToAssign[i] = rolesInGame[i];
        }
    }

}
