using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StaminaUpdate : MonoBehaviour {

    GameObject Player;

    Playerstatus Status;

    MovimentaçãoPlayer Correndo;

    public Text UpdateStamina;

	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Player");

        Status = Player.GetComponent<Playerstatus>();

        UpdateStamina.text = "Stamina: " + Mathf.Round(Status.Stamina);
        
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.LeftShift) && Status.Stamina > 0)
        {
            Status.Stamina -= 2.0f * Time.deltaTime;
        }
        else
        {
            Status.Stamina += 0.8f * Time.deltaTime;
        }
        UpdateStamina.text = "Stamina: " + Mathf.Round(Status.Stamina);

    }
}
