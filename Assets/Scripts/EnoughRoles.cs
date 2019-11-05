using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnoughRoles : MonoBehaviour
{
    public int numRolesSelected;


    // Start is called before the first frame update
    void Start()
    {
        numRolesSelected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (numRolesSelected == GameController.numPlayers + 3)
        {
            gameObject.GetComponent<DisableableButton>().EnableButton();
        }

        else
        {
            gameObject.GetComponent<DisableableButton>().DisableButton();
        }
    }

    public void RoleSelected()
    {
        numRolesSelected++;
    }

    public void RoleDeselected()
    {
        numRolesSelected--;
    }


}
