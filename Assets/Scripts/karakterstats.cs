using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class karakterstats : MonoBehaviour
{
    public GameObject panel;

    public static float health;
    public float maxHealth = 100;
    public Image healthBar;

    private void Awake() {
        health = maxHealth;
        Time.timeScale = 1.0f;
    }

    private void Update() {
        if (health <= 0)
        {
            DeadPanel();
        }

        if (health < 0)
        {
            health = 0;
        }

        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
    }

    public void DeadPanel(){
        panel.SetActive(true);
        Time.timeScale = 0.0f;
        Cursor.lockState = CursorLockMode.None;   
        Cursor.visible = true;



    }
    public void restartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        Cointext.coinsayisi = 0;

    }
  
}
