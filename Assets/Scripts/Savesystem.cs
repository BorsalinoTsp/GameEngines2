using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Savesystem : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider) {
        if(collider.CompareTag("Player")){
            string activeScene = SceneManager.GetActiveScene().name;
            PlayerPrefs.SetString("LevelSaved", activeScene);
            Debug.Log(activeScene);
            gameObject.SetActive(false);
        }
        
    }
}
