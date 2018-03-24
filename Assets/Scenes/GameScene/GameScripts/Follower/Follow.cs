using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    GameObject Jogador;
    Transform DoJogador;

    Rigidbody RbCubo;

    Vector3 nv;
   

    bool following = false;


	// Use this for initialization
	void Start () {
        Jogador = GameObject.Find("Player");
        DoJogador = Jogador.GetComponent<Transform>();

        RbCubo = GetComponent<Rigidbody>();
	}



    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colidiu");
    }

    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKey(KeyCode.E))
        {
            following = true;
        }
    }


    private void FixedUpdate()
    {

        if (following == true)
        {
            nv.x = DoJogador.position.x - transform.position.x;
            nv.y = DoJogador.position.y * 0;
            nv.z = DoJogador.position.z - transform.position.z;
            nv.Normalize();
            transform.position += nv * Time.deltaTime;
        }

    }
    // Update is called once per frame
    void Update () {
		
	}
}
