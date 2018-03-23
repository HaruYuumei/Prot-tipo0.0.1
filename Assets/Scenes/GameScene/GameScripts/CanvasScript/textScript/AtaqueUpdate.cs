using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AtaqueUpdate : MonoBehaviour {

    GameObject Player;
    Playerstatus Status;

    public Text log;

	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Player");
        Status = Player.GetComponent<Playerstatus>();
	}
	
	// Update is called once per frame
	void Update () {
        log.text = "Ataque: " + Status.Ataque;
    }
}
