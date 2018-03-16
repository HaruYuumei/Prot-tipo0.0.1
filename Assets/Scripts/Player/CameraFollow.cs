using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform Player;
    public Camera cam;
    Vector3 offset;
  

    // Use this for initialization
    void Start () {
        cam.GetComponent<Camera>();
        offset.x = 0;
        offset.y = -15;
        offset.z = 0;
	}
	
	// Update is called once per frame
	void Update () {
        cam.transform.position = new Vector3(Player.transform.position.x - offset.x,
                                             Player.transform.position.y - offset.y,
                                             Player.transform.position.z - offset.z);

       

       
    }
}
