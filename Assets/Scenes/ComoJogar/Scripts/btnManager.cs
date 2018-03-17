using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class btnManager : MonoBehaviour {

	public void backScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
