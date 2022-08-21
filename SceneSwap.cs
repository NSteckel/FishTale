using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour
{
    private void OnTriggerEnter(Collider colliderObject) {
        SceneManager.LoadScene("Scene_Puzzle");
        //SceneManager.LoadScene("Scene_Two");
        //SceneManager.LoadScene("SceneTestThree");

        //DontDestroyOnLoad(colliderObject);
    }    

}
