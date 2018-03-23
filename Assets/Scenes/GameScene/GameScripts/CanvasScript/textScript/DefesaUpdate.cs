using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DefesaUpdate : MonoBehaviour {

    GameObject Player;
    Playerstatus Status;

    public Text UpdateDefesa;


	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Player");
        Status = Player.GetComponent<Playerstatus>();
	}
	
	// Update is called once per frame
	void Update () {
        UpdateDefesa.text = "Defesa: " + Status.Defesa;
	}
}
