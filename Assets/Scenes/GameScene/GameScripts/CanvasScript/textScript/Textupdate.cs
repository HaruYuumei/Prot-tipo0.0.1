using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Textupdate : MonoBehaviour {
    public float fome = 100;
    public Text Txt;

	// Use this for initialization
	void Start () {
        Txt.text = "Fome: " + fome;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
