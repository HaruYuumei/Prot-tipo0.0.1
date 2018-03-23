using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisaoSede : MonoBehaviour {

    GameObject Player;
    Playerstatus Status;

	// Use this for initialization
	void Start () {

        Player = GameObject.Find("Player");
        Status = Player.GetComponent<Playerstatus>();

	}
	
    void OnTriggerEnter(Collider Other)
    {
        Debug.Log("AGUAAAAAAAAAA");
    }


    void OnTriggerStay(Collider Other)
    {
        if(Input.GetKey(KeyCode.E))
        {
            if (Status.Sede < 100)
            {
                Status.Sede++;
            }
            
        }
    }

    void OnTriggerExit(Collider Other)
    {
        Debug.Log(" ");
    }
	
}
