using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {

    Collision PlayerCol;
    GameObject Player;


	// Use this for initialization
	void Start () {
		Player = GameObject.Find("Player");

        PlayerCol = Player.GetComponent<Collision>();
	}


    private void OnCollisionEnter(Collision PlayerCol)
    {
        Debug.Log("Colidiu");
    }


    // Update is called once per frame
    void Update () {
		
	}
}
