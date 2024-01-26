using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Soundop : MonoBehaviour
{

   public TextMeshProUGUI volumeAmount;
   public Slider slider;
    void Start() {
        loadAudio();

    }
   public void setAudio(float value){
    AudioListener.volume = value;
    volumeAmount.text = ((int)(value*100)).ToString();
    saveAudio();

   }


   private void saveAudio(){
    PlayerPrefs.SetFloat("AudioVolume",AudioListener.volume);
   }
   private void loadAudio(){
    if(PlayerPrefs.HasKey("AudioVolume")){
        AudioListener.volume = PlayerPrefs.GetFloat("AudioVolume");
        slider.value = PlayerPrefs.GetFloat("AudioVolume");
    }
    else {
        PlayerPrefs.SetFloat("AudioVolume", 0.5f);
        AudioListener.volume = PlayerPrefs.GetFloat("AudioVolume");
        slider.value = PlayerPrefs.GetFloat("AudioVolume");
    }
   }
   

}
