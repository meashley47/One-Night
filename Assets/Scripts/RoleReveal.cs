using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class RoleReveal : MonoBehaviour
{
    public Text text;
    public Button next;
    public Button reveal;
    public InputField input;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reveal()
    {
        string pname = PlayerName.playerName;
        Debug.Log(PlayerRoles.index);
        PlayerRoles.players[PlayerRoles.index] = pname;

        input.interactable = false;
        reveal.interactable = false;
        text.text = "You are...\n\n";
        int indexToRemove = RandomNumber(GameController.rolesToAssign.Length);
        text.text += GameController.rolesToAssign[indexToRemove];

        PlayerRoles.playerRoles[PlayerRoles.index] = GameController.rolesToAssign[indexToRemove];
        PlayerRoles.originalRoles[PlayerRoles.index] = GameController.rolesToAssign[indexToRemove];
        PlayerRoles.index++;

        GameController.rolesToAssign = GameController.rolesToAssign.Where((source, index) => index != indexToRemove).ToArray();
        next.interactable = true;

        //We have the 3 center cards remaining
        if (PlayerRoles.index >= GameController.numPlayers)
        {
            PlayerRoles.players[PlayerRoles.index] = "Extra Role 1";
            indexToRemove = RandomNumber(GameController.rolesToAssign.Length);
            PlayerRoles.playerRoles[PlayerRoles.index] = GameController.rolesToAssign[indexToRemove];
            PlayerRoles.originalRoles[PlayerRoles.index] = GameController.rolesToAssign[indexToRemove];
            PlayerRoles.index++;
            GameController.rolesToAssign = GameController.rolesToAssign.Where((source, index) => index != indexToRemove).ToArray();

            PlayerRoles.players[PlayerRoles.index] = "Extra Role 2";
            indexToRemove = RandomNumber(GameController.rolesToAssign.Length);
            PlayerRoles.playerRoles[PlayerRoles.index] = GameController.rolesToAssign[indexToRemove];
            PlayerRoles.originalRoles[PlayerRoles.index] = GameController.rolesToAssign[indexToRemove];
            PlayerRoles.index++;
            GameController.rolesToAssign = GameController.rolesToAssign.Where((source, index) => index != indexToRemove).ToArray();

            PlayerRoles.players[PlayerRoles.index] = "Extra Role 3";
            indexToRemove = RandomNumber(GameController.rolesToAssign.Length);
            PlayerRoles.playerRoles[PlayerRoles.index] = GameController.rolesToAssign[indexToRemove];
            PlayerRoles.originalRoles[PlayerRoles.index] = GameController.rolesToAssign[indexToRemove];
            PlayerRoles.index++;
            GameController.rolesToAssign = GameController.rolesToAssign.Where((source, index) => index != indexToRemove).ToArray();
        }
    }

    public int RandomNumber(int max)
    {
        System.Random random = new System.Random();

        //Possible numbers are 0 - (max-1)
        return random.Next(max);
    }

}
