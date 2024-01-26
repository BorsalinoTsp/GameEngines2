using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    public GameObject optionsPanel;
    [SerializeField] private string newGameLevel;
    public void newGameButton(){
        SoundManagerSC.audioSource.PlayOneShot(SoundManagerSC.instance.clickClip);
        SceneManager.LoadScene(newGameLevel);
        Time.timeScale = 1.0f;
    }
    public void LoadGameButton(){
        SoundManagerSC.audioSource.PlayOneShot(SoundManagerSC.instance.clickClip);
        if(PlayerPrefs.HasKey("LevelSaved")){
            string levelToLoad = PlayerPrefs.GetString("LevelSaved");
            SceneManager.LoadScene(levelToLoad);
            Time.timeScale =  1.0f;
            
        }
    }
    public void Menu(){
        SoundManagerSC.audioSource.PlayOneShot(SoundManagerSC.instance.clickClip);
        SceneManager.LoadScene(0);
        Cointext.coinsayisi = 0;
        Cursor.visible = enabled;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Options(){
        SoundManagerSC.audioSource.PlayOneShot(SoundManagerSC.instance.clickClip);
        optionsPanel.SetActive(true);

    }
    public void CloseOptions(){
        SoundManagerSC.audioSource.PlayOneShot(SoundManagerSC.instance.clickClip);
        optionsPanel.SetActive(false);
    }

    public void Quitgame(){
        SoundManagerSC.audioSource.PlayOneShot(SoundManagerSC.instance.clickClip);
        Application.Quit();
    }
    
}
