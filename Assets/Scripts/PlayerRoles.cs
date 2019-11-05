using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRoles : MonoBehaviour
{
    public static int index = 0;
    public static string[] players = new string[GameController.numPlayers + 3];
    public static string[] playerRoles = new string[GameController.numPlayers + 3];
    public static string[] originalRoles = new string[GameController.numPlayers + 3];

    public Text text;
    public Button button;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Print()
    {
        text.text = "";
        for (int i = 0; i < players.Length; i++)
        {
            text.text += players[i] + ": " + playerRoles[i] + "\n";
        }

        button.gameObject.SetActive(false);
     }
}
