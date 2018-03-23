using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisaoComida : MonoBehaviour
{

    GameObject Player;
    Playerstatus status;

    void Start()
    {
        Player = GameObject.Find("Player");
        status = Player.GetComponent<Playerstatus>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("COMIDAAAAAAAAAAAAAAA");
        }
        
       
    }

    void OnTriggerStay(Collider other)
    {
        if(Input.GetKey(KeyCode.E))
        {
            if (status.Fome < 100)
            {
                status.Fome++;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {

      Debug.Log(" ");
    }


}

