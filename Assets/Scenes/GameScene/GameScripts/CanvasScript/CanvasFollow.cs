using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFollow : MonoBehaviour
{

    public Transform Player;
    public Canvas canv;
    Vector3 offset;


    // Use this for initialization
    void Start()
    {
        canv.GetComponent<Canvas>();
        offset.x = 0;
        offset.y = -15;
        offset.z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        canv.transform.position = new Vector3(Player.transform.position.x ,
                                             Player.transform.position.y ,
                                             Player.transform.position.z);




    }
}
