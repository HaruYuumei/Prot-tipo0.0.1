using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerstatus : MonoBehaviour {

    
    public float Fome;
    public float Sede;
    public float Stamina;

    public float Ataque;
    public float Defesa;



	// Use this for initialization
	void Start () {

        Fome = 100;
        Sede = 100;
        Stamina = 10;

        Ataque = 5;
        Defesa = 2;
	}
	
	// Update is called once per frame
	void Update () {
		
        //Aumentando a fome ao chegar em 0
        if(Fome <= 0)
        {
            Fome++;
        }

        //Aumentando a Sede ao chegar em 0
        if (Sede <= 0)
        {
            Sede++;
        }

        //Aumentando a Stamina ao chegar em 0
        if (Stamina < 0 && Stamina > 0.9)
        {
            Stamina = 0;
            Stamina += 0.3f * Time.deltaTime;
        }
        if (Stamina >= 10)
        {
            Stamina = 10;
        }



    }
}
