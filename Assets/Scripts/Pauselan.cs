using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pauselan : MonoBehaviour
{
    public GameObject durlan;
    public GameObject volume;
    bool pauseMenuIsActive = false;

    private void Awake() {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update() {
        if (pauseMenuIsActive == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pauseMenuIsActive = true;
                durlan.SetActive(true);
                Time.timeScale = 0.0f;
                Cursor.visible = enabled;
                Cursor.lockState = CursorLockMode.None;
            }
        }
        else if (pauseMenuIsActive == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pauseMenuIsActive = false;
                durlan.SetActive(false);
                Time.timeScale = 1.0f;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        
    }
    public void Stop(){
        SoundManagerSC.audioSource.PlayOneShot(SoundManagerSC.instance.clickClip);
        durlan.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void Continue(){
        SoundManagerSC.audioSource.PlayOneShot(SoundManagerSC.instance.clickClip);
        durlan.SetActive(false);
        Time.timeScale = 1.0f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Options(){
        SoundManagerSC.audioSource.PlayOneShot(SoundManagerSC.instance.clickClip);
        volume.SetActive(true);

    }
    public void Qoptions(){
        SoundManagerSC.audioSource.PlayOneShot(SoundManagerSC.instance.clickClip);
        volume.SetActive(false);
    }
   
}
