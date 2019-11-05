using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichRoles : MonoBehaviour
{
    public static bool doppel = false;
    public static bool drunk = false;
    public static bool insomniac = false;
    public static bool mason = false;
    public static bool minion = false;
    public static bool robber = false;
    public static bool seer = false;
    public static bool troublemaker = false;
    public static bool werewolf = false;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < GameController.rolesInGame.Length; i++)
        {
            if (GameController.rolesInGame[i] == "Doppelganger")
            {
                doppel = true;
            }
            else if (GameController.rolesInGame[i] == "Drunk")
            {
                drunk = true;
            }
            else if (GameController.rolesInGame[i] == "Insomniac")
            {
                insomniac = true;
            }
            else if (GameController.rolesInGame[i] == "Mason")
            {
                mason = true;
            }
            else if (GameController.rolesInGame[i] == "Minion")
            {
                minion = true;
            }
            else if (GameController.rolesInGame[i] == "Robber")
            {
                robber = true;
            }
            else if (GameController.rolesInGame[i] == "Seer")
            {
                seer = true;
            }
            else if (GameController.rolesInGame[i] == "Troublemaker")
            {
                troublemaker = true;
            }
            else if (GameController.rolesInGame[i] == "Werewolf")
            {
                werewolf = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
