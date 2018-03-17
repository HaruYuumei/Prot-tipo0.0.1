using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class PlayManager : MonoBehaviour {

	public void changeScene()
    {
        SceneManager.LoadScene("GameScene");
    }

 
}
