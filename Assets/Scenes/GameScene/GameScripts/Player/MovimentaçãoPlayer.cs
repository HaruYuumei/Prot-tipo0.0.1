using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentaçãoPlayer : MonoBehaviour {

    Rigidbody rb;

    GameObject Jogador;
    Playerstatus StatusDoJogador;

    //testando
    [SerializeField]
    float Speed;
    [SerializeField]
    float RunningSpeed;
    [SerializeField]
    float RotationSpeed;



    // Use this for initialization
    void Start () {

        //rigidbody
        rb = GetComponent<Rigidbody>();

        //dizendo quem é o jogador
        Jogador = GameObject.Find("Player");

        //pegando o playerstatus
        StatusDoJogador = Jogador.GetComponent<Playerstatus>();


        //variaveis//

        //velocidade
        Speed = 10.0f;
        //velocidade correndo
        RunningSpeed = 25.0f;
        //velocidade de rotação
        RotationSpeed = 140.0f;


    }
	
	// Update is called once per frame
	void Update () {

        //                          Movimentação do jogador         ///         rb.AddForce(new Vector3(Input.GetAxis("Vertical"),0, Input.GetAxis("Horizontal")));

        //frente
        if(Input.GetKey(KeyCode.W))
        {
            rb.transform.Translate(Vector3.up * (Time.deltaTime * Speed));
        }

        //tras
        if (Input.GetKey(KeyCode.S))
        {
            rb.transform.Translate(Vector3.down * (Time.deltaTime * 2.0f));
        }

        //esquerda
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.Rotate(Vector3.right * (Time.deltaTime * RotationSpeed));
        }

        //direita
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.Rotate(Vector3.left * (Time.deltaTime * RotationSpeed));
        }

        //Somente Correr se a Stamina for maior q 0
        if (Input.GetKey(KeyCode.LeftShift) && StatusDoJogador.Stamina > Mathf.Round(0))
        {
            Speed = RunningSpeed;
        }
        else
        {
            Speed = 10.0f;
        }

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pulou!"); 
        }
        //testando
        //Pq nao ta funfando o import do collab??

    }
}
