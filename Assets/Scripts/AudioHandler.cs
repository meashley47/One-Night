using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AudioHandler : MonoBehaviour
{
    public AudioSource sound;
      
    bool start = true;
    bool end = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (start && !sound.isPlaying)
        {
            sound.Play();
            start = false;
            end = true;
        }

        //Sound is done playing
        else if (end && !sound.isPlaying)
        {
            //Go to next scene/sound needed
            int curr = SceneManager.GetActiveScene().buildIndex;
            int next = NextSceneNeeded(curr);

            if (curr == 5 || curr == 6 || curr == 9 || curr == 11 || curr == 13 || curr == 15 || 
                curr == 17 || curr == 19 || curr == 21 || curr == 23 || curr == 25)
            {
                //Want to give the werewolves some extra time
                if (Time.timeSinceLevelLoad > 15)
                {
                    gameObject.GetComponent<GameController>().SpecificScene(next);
                }
            }
            else
            {
                gameObject.GetComponent<GameController>().SpecificScene(next);
            }
        }
    }

    int NextSceneNeeded(int curr)
    {
        //Doppelganger is up first. Close your eyes is scene 4
        if (WhichRoles.doppel && curr == 4)
        {
            return 5;
        }

        //If doppelganger is in play and so is minion, do the doppel minion prompt
        if (WhichRoles.minion && curr == 5)
        {
            return 6;
        }

        //If doppelganger is in play and so is minion, do the doppel minion CE prompt
        if (curr == 6)
        {
            return 7;
        }

        //If doppelganger but no minion is in play, do the regular doppel CE prompt
        if (curr == 5)
        {
            return 8;
        }

        //Werewolves
        if (WhichRoles.werewolf && curr < 9)
        {
            return 9;
        }

        //Werewolves CE
        if (curr == 9)
        {
            return 10;
        }

        //Minions
        if (WhichRoles.minion && curr < 11)
        {
            return 11;
        }

        //Minions CE
        if (curr == 11)
        {
            return 12;
        }

        //Mason
        if (WhichRoles.mason && curr < 13)
        {
            return 13;
        }

        //Mason CE
        if (curr == 13)
        {
            return 14;
        }

        //Seer
        if (WhichRoles.seer && curr < 15)
        {
            return 15;
        }

        //Seer CE
        if (curr == 15)
        {
            return 16;
        }

        //Robber
        if (WhichRoles.robber && curr < 17)
        {
            return 17;
        }

        //Robber CE
        if (curr == 17)
        {
            return 18;
        }

        //Troublemaker
        if (WhichRoles.troublemaker && curr < 19)
        {
            return 19;
        }

        //Troublemaker CE
        if (curr == 19)
        {
            return 20;
        }

        //Drunk 
        if (WhichRoles.drunk && curr < 21)
        {
            return 21;
        }

        //Drunk CE
        if (curr == 21)
        {
            return 22;
        }

        //Insomniac
        if (WhichRoles.insomniac && curr < 23)
        {
            return 23;
        }

        //Insomniac CE
        if (curr == 23)
        {
            return 24;
        }

        //Doppel insom if they're both in play
        if (WhichRoles.doppel && WhichRoles.insomniac && curr < 25)
        {
            return 25;
        }

        //Doppel CE as normal
        if (curr == 25)
        {
            return 26;
        }

        //Everyone wake up
        if (curr < 27)
        {
            return 27;
        }

        return 28;
    }
}
