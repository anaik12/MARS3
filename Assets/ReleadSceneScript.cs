using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReleadSceneScript : MonoBehaviour {

	// Use this for initialization


    void OnMouseDown() {
        Debug.Log("Reload");
        print("reload");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Reload");
        print("reload");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame

}
