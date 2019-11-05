using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drunk : MonoBehaviour
{
    public Button role1;
    public Button role2;
    public Button role3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Picked(int roleNum)
    {
        role1.gameObject.SetActive(false);
        role2.gameObject.SetActive(false);
        role3.gameObject.SetActive(false);

        //Switch the drunk's role with the role they chose

        int drunkIndex = -1;

        //Find the drunk index
        for (int i = 0; i < PlayerRoles.playerRoles.Length; i++)
        {
            if (PlayerRoles.originalRoles[i] == "Drunk")
            {
                drunkIndex = i;
            }
        }

        string temp = PlayerRoles.playerRoles[drunkIndex];
        PlayerRoles.playerRoles[drunkIndex] = PlayerRoles.playerRoles[PlayerRoles.playerRoles.Length - 4 + roleNum];
        PlayerRoles.playerRoles[PlayerRoles.playerRoles.Length - 4 + roleNum] = temp;
    }
}
