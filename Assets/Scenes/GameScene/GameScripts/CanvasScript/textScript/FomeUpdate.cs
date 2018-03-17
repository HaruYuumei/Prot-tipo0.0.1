using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FomeUpdate : MonoBehaviour {
    GameObject Player;
    Playerstatus Status;
    public Text Txt;

	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Player");
        Status = Player.GetComponent<Playerstatus>();
        Txt.text = "Fome: " + Status.Fome;
	}
	
	// Update is called once per frame
	void Update () {
        Txt.text = "Fome: " + Mathf.Round(Status.Fome);
        Status.Fome -= 1 * Time.deltaTime;
	}
}
