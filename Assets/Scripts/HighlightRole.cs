using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighlightRole : MonoBehaviour
{
    public static bool[] roleArray = new bool[16];
    public GameObject[] highlights = new GameObject[16];
    public GameObject highlight0;
    public GameObject highlight1;
    public GameObject highlight2;
    public GameObject highlight3;
    public GameObject highlight4;
    public GameObject highlight5;
    public GameObject highlight6;
    public GameObject highlight7;
    public GameObject highlight8;
    public GameObject highlight9;
    public GameObject highlight10;
    public GameObject highlight11;
    public GameObject highlight12;
    public GameObject highlight13;
    public GameObject highlight14;
    public GameObject highlight15;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 16; i++)
        {
            roleArray[i] = false;
        }

        highlights[0] = highlight0;
        highlights[1] = highlight1;
        highlights[2] = highlight2;
        highlights[3] = highlight3;        
        highlights[4] = highlight4;
        highlights[5] = highlight5;
        highlights[6] = highlight6;
        highlights[7] = highlight7;
        highlights[8] = highlight8;
        highlights[9] = highlight9;
        highlights[10] = highlight10;
        highlights[11] = highlight11;
        highlights[12] = highlight12;
        highlights[13] = highlight13;
        highlights[14] = highlight14;
        highlights[15] = highlight15;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick(int index)
    {
        roleArray[index] = !roleArray[index];

        if (roleArray[index])
        {
            gameObject.GetComponent<EnoughRoles>().RoleSelected();
            highlights[index].SetActive(true);
        }

        else
        {
            gameObject.GetComponent<EnoughRoles>().RoleDeselected();
            highlights[index].SetActive(false);
        }
    }
}
