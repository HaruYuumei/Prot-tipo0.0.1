using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SedeUpdate : MonoBehaviour {


    //Pegando o Player
    GameObject Player;

    //Pegando Status do player
    Playerstatus Status;

    //pegando o txt do hud
    public Text UpdateStatus;

	// Use this for initialization
	void Start () {
		
        //dizendo quem é o player
        Player = GameObject.Find("Player");

        //Dizendo quem é o status do player
        Status = Player.GetComponent<Playerstatus>();


        UpdateStatus.text = "Sede: " + Mathf.Round(Status.Sede);

	}
	
	// Update is called once per frame
	void Update () {

        //perder sede quando correr
        if(Input.GetKey(KeyCode.LeftShift))
        {
            Status.Sede -= 1.2f * Time.deltaTime;
        }
        else
        {
            //diminuindo por segundo * deltatime
            Status.Sede -= 1 * Time.deltaTime;
        }

        //re-escrevendo o valor na tela
        UpdateStatus.text = "Sede: " + Mathf.Round(Status.Sede);
    }
}
