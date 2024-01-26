using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cointext : MonoBehaviour
{

    Text coinText;
    public static int coinsayisi;
    
    void Start()
    {
        coinText = GameObject.FindGameObjectWithTag("Coin Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "" +coinsayisi+ " / 5";
    }
}
