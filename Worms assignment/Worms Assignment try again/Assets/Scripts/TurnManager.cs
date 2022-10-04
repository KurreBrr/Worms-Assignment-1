using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurnManager : MonoBehaviour
{
    public GameObject[] players;
    private int turn;
    public TextMeshProUGUI timerText;
    private float playTimer;

    public float turnTime = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //increase timer
        playTimer += Time.deltaTime;
        timerText.text = "Time left: " + (turnTime - Mathf.RoundToInt(playTimer));


        if (players[turn] != null && players[(turn + 1) % 2] != null)
        {
            //active player
            players[turn].GetComponent<CharacterMovement>().canMove = true;
            players[turn].transform.GetChild(0).GetComponent<Camera>().enabled = true;
            players[turn].transform.GetChild(0).GetComponent<AudioListener>().enabled = false;
            players[turn].transform.GetChild(0).GetComponent<MouseLook>().enabled = true;

            //inactive player
            players[(turn + 1) % 2].GetComponent<CharacterMovement>().canMove = false;
            players[(turn + 1) % 2].transform.GetChild(0).GetComponent<Camera>().enabled = false;
            players[(turn + 1) % 2].transform.GetChild(0).GetComponent<AudioListener>().enabled = false;
            players[(turn + 1) % 2].transform.GetChild(0).GetComponent<MouseLook>().enabled = false;

            //changes turn after 10s
            if(playTimer > turnTime)
            {
                turn = ((turn + 1) % 2);
                playTimer = 0;
            }
        }
       


        //win check
        if (players[0] == null)
        {
            
            print("player 2 won!");
        }
        else if (players[1] == null)
        {
            
            print("player 1 won!");
        }
    }
}
