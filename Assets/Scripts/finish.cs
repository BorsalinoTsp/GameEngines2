using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    public string nextlevel;

     void OnTriggerEnter(Collider collider) {
         if (collider.gameObject.name == "karakter") {
             PlayerPrefs.SetInt(nextlevel,1);
             Debug.Log(nextlevel+ "Unlocked.");
             SceneManager.LoadScene ("Level1");
         }
        
    }
    
}
