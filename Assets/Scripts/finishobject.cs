using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishobject : MonoBehaviour
{
    public GameObject nextlvlpanel;
    public GameObject interactable;
    public string SceneName;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(Cointext.coinsayisi == 5)
            {

                nextlvlpanel.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
      if(collision.transform.tag == "Player" && Cointext.coinsayisi >= 5)
      {
        
            interactable.SetActive(true);

      }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.transform.tag == "Player" && Cointext.coinsayisi >= 5)
        {

            interactable.SetActive(false);

        }
    }
    public void NextLevel()
    {
    nextlvlpanel.SetActive(false);
     SceneManager.LoadScene(SceneName);
    Cointext.coinsayisi = 0;

    }
}
